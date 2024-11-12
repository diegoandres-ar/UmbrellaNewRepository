using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioJuegos : ConexionOracle
    {
        RepositorioCategorias repositorioCategorias = new RepositorioCategorias();
        RepositorioPlataformas repositorioPlataformas = new RepositorioPlataformas();

        public string Eliminar(string id)
        {
            string query = "DELETE FROM JUEGOS WHERE ID = :IdJuego";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdJuego", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el juego para eliminar.";
                    }
                }
                transaction.Commit();
                return "Registro eliminado.";
            }
            catch (OracleException ex)
            {
                transaction?.Rollback();
                return "Error en la base de datos: " + ex.Message;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                return "Error: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public Juego BuscarPorId(string id)
        {
            Juego juego = null;
            string query = "SELECT * FROM JUEGOS WHERE ID = :IdJuego";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdJuego", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            juego = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró el juego con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return juego;
        }

        public string Modificar(Juego juego)
        {
            string query = "UPDATE JUEGOS SET DESCRIPCION = :Descripcion, FORMATO = :Formato, PORTADA = :Portada, " +
                "ANIO_LANZAMIENTO = :AnioLanzamiento, PRECIO = :Precio, CANTIDAD = :Cantidad, ID_CATEGORIA = :IdCategoria, " +
                "ID_PLATAFORMA = :IdPlataforma WHERE ID = :IdJuego";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", juego.Titulo));
                    command.Parameters.Add(new OracleParameter("Formato", juego.Formato));
                    command.Parameters.Add(new OracleParameter("Portada", ConvertImageToBlob(juego.Portada)));
                    command.Parameters.Add(new OracleParameter("AnioLanzamiento", juego.AnioLanzamiento));
                    command.Parameters.Add(new OracleParameter("Precio", juego.Precio));
                    command.Parameters.Add(new OracleParameter("Cantidad", juego.Stock));
                    command.Parameters.Add(new OracleParameter("IdCategoria", juego.Categoria.Id));
                    command.Parameters.Add(new OracleParameter("IdPlataforma", juego.Plataforma.Id));
                    command.Parameters.Add(new OracleParameter("IdJuego", juego.Id));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el juego para modificar.";
                    }
                }
                transaction.Commit();
                return "Registro modificado.";
            }
            catch (OracleException ex)
            {
                transaction?.Rollback();
                return "Error en la base de datos: " + ex.Message;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                return "Error: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Juego> ObtenerTodo()
        {
            List<Juego> listaJuegos = new List<Juego>();
            string query = "SELECT * FROM JUEGOS";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaJuegos.Add(Map(reader));
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return listaJuegos;
        }

        public string Registrar(Juego juego)
        {
            string registro = "INSERT INTO JUEGOS (ID, DESCRIPCION, FORMATO, PORTADA, ANIO_LANZAMIENTO, PRECIO, CANTIDAD, ID_CATEGORIA, ID_PLATAFORMA) VALUES (:IdJuego, :Descripcion, :Formato, :Portada, :AnioLanzamiento, :Precio, :Cantidad, :IdCategoria, :IdPlataforma)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(registro, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdJuego", juego.Id));
                    command.Parameters.Add(new OracleParameter("Descripcion", juego.Titulo));
                    command.Parameters.Add(new OracleParameter("Formato", juego.Formato));
                    command.Parameters.Add(new OracleParameter("Portada", ConvertImageToBlob(juego.Portada)));
                    command.Parameters.Add(new OracleParameter("AnioLanzamiento", juego.AnioLanzamiento));
                    command.Parameters.Add(new OracleParameter("Precio", juego.Precio));
                    command.Parameters.Add(new OracleParameter("Cantidad", juego.Stock));
                    command.Parameters.Add(new OracleParameter("IdCategoria", juego.Categoria.Id));
                    command.Parameters.Add(new OracleParameter("IdPlataforma", juego.Plataforma.Id));
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                return "Registro exitoso.";
            }
            catch (OracleException ex)
            {
                transaction?.Rollback();
                return "Error en la base de datos: " + ex.Message;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                return "Error: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Juego> FiltrarPorAnioLanzamiento(int anioInicio, int anioFin)
        {
            List<Juego> listaJuegos = new List<Juego>();
            string query = "";

            if (anioFin == 0)
            {
                query = "SELECT * FROM JUEGOS WHERE ANIO_LANZAMIENTO = :AñoInicio";
            }
            else
            {
                query = "SELECT * FROM JUEGOS WHERE ANIO_LANZAMIENTO >= :AñoInicio AND ANIO_LANZAMIENTO <= :AñoFin";
            }

            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("AñoInicio", anioInicio));

                    if (anioFin != 0)
                    {
                        command.Parameters.Add(new OracleParameter("AñoFin", anioFin));
                    }

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaJuegos.Add(Map(reader));
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                CerrarConexion();
            }

            return listaJuegos;
        }



        private Juego Map(OracleDataReader reader)
        {
            Categoria categoria = repositorioCategorias.BuscarPorId(Convert.ToString(reader["ID_CATEGORIA"]));
            Plataforma plataforma = repositorioPlataformas.BuscarPorId(Convert.ToString(reader["ID_PLATAFORMA"]));
            return new Juego(
                Convert.ToString(reader["ID"]),
                Convert.ToString(reader["DESCRIPCION"]),
                Convert.ToString(reader["FORMATO"]),
                reader["PORTADA"] != DBNull.Value ? (byte[])reader["PORTADA"] : null,
                reader["ANIO_LANZAMIENTO"] != DBNull.Value ? Convert.ToInt32(reader["ANIO_LANZAMIENTO"]) : 0,
                reader["PRECIO"] != DBNull.Value ? Convert.ToDouble(reader["PRECIO"]) : 0.0,
                reader["CANTIDAD"] != DBNull.Value ? Convert.ToInt32(reader["CANTIDAD"]) : 0,
                categoria,
                plataforma
            );
        }

        private byte[] ConvertImageToBlob(byte[] imageBytes)
        {
            return imageBytes;
        }
    }
}