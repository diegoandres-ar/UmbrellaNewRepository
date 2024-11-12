using Dropbox.Api;
using Dropbox.Api.Files;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosDropBox
    {
        private static readonly string DropboxApiUrl = "https://content.dropboxapi.com/2/files/upload";
        private static readonly string AccessToken = "sl.CAkfqLiVy_iQBp6hTPI-p0Q5s6nvVesqgw8hipXOjpAzY4" +
            "cwFWeGfZ9dTQspvafxVRBj-IAmoFHHqeL1Kuz-SEugWFRsGctAuGJiPxoHthuzYQp0cNPjj8g7EVsVFYrmK-ceRHWo" +
            "4FpIOIvD8_3vJNk";

        public static async Task<string> UploadFileToDropboxAsync(string filePath)
        {
            string dropboxPath = "/" + Path.GetFileName(filePath); 

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, DropboxApiUrl);
                request.Headers.Add("Authorization", "Bearer " + AccessToken);
                request.Headers.Add("Dropbox-API-Arg", $"{{\"path\": \"{dropboxPath}\", \"mode\": \"add\", \"autorename\": true, \"mute\": false}}");

                byte[] fileContents = File.ReadAllBytes(filePath);
                request.Content = new ByteArrayContent(fileContents);
                request.Content.Headers.Add("Content-Type", "application/octet-stream");

                try
                {
                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseBody);
                        string uploadedFilePath = jsonResponse["path_display"].ToString();

                        string sharedLink = await GetSharedLink(uploadedFilePath);
                        return sharedLink;
                    }
                    else
                    {
                        Console.WriteLine("Error al subir el archivo: " + await response.Content.ReadAsStringAsync());
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        private static async Task<string> GetSharedLink(string filePath)
        {
            string sharedLinkApiUrl = "https://api.dropboxapi.com/2/sharing/create_shared_link_with_settings";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + AccessToken);

                var body = new
                {
                    path = filePath,
                    settings = new
                    {
                        requested_visibility = "public"
                    }
                };

                string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(body);

                try
                {
                    HttpResponseMessage response = await client.PostAsync(
                        sharedLinkApiUrl,
                        new StringContent(jsonBody, Encoding.UTF8, "application/json")
                    );

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseBody);
                        string sharedLink = jsonResponse["url"].ToString();

                        return ConvertToDirectLink(sharedLink);
                    }
                    else
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        if (responseBody.Contains("shared_link_already_exists"))
                        {
                            Console.WriteLine("El enlace compartido ya existe. Usando el enlace existente.");
                            return await GetExistingSharedLink(filePath);
                        }

                        Console.WriteLine("Error al obtener el enlace compartido: " + responseBody);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la obtención del enlace compartido: " + ex.Message);
                    return null;
                }
            }
        }

        private static async Task<string> GetExistingSharedLink(string filePath)
        {
            string listSharedLinksApiUrl = "https://api.dropboxapi.com/2/sharing/list_shared_links";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + AccessToken);

                var body = new { path = filePath };

                string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(body);

                HttpResponseMessage response = await client.PostAsync(
                    listSharedLinksApiUrl,
                    new StringContent(jsonBody, Encoding.UTF8, "application/json")
                );

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject jsonResponse = JObject.Parse(responseBody);

                    if (jsonResponse["links"].Any())
                    {
                        string sharedLink = jsonResponse["links"][0]["url"].ToString();
                        return ConvertToDirectLink(sharedLink);
                    }
                }

                return null;
            }
        }

        private static string ConvertToDirectLink(string dropboxLink)
        {
            return dropboxLink.Replace("www.dropbox.com", "dl.dropboxusercontent.com").Replace("?dl=0", "");
        }
    }
}