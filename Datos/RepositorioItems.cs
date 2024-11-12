using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioItems : ConexionOracle
    {
        public string Registrar(Item item, string idFactura)
        {
            string query = "INSERT INTO items (ID, ID_JUEGO, CANTIDAD, SUBTOTAL, ID_FACTURA) VALUES (:IdItem, :IdJuego, :Cantidad, :Subtotal, :IdFactura)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdItem", item.Id));
                    command.Parameters.Add(new OracleParameter("IdJuego", item.Juego.Id));
                    command.Parameters.Add(new OracleParameter("Cantidad", item.Cantidad));
                    command.Parameters.Add(new OracleParameter("Subtotal", item.Subtotal));
                    command.Parameters.Add(new OracleParameter("IdFactura", idFactura));
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

        public string Eliminar(string id)
        {
            string query = "DELETE FROM items WHERE ID = :IdItem";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdItem", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el item para eliminar.";
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

        public Item BuscarPorId(string id)
        {
            Item item = null;
            string query = "SELECT * FROM items WHERE ID = :IdItem";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdItem", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró el item con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (OracleException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return item;
        }

        public string Modificar(Item item, string idFactura)
        {
            string query = "UPDATE items SET ID_JUEGO = :IdJuego, CANTIDAD = :Cantidad, SUBTOTAL = :Subtotal, ID_FACTURA = :IdFactura WHERE ID = :IdItem";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdJuego", item.Juego.Id));
                    command.Parameters.Add(new OracleParameter("Cantidad", item.Cantidad));
                    command.Parameters.Add(new OracleParameter("Subtotal", item.Subtotal));
                    command.Parameters.Add(new OracleParameter("IdFactura", idFactura));
                    command.Parameters.Add(new OracleParameter("IdItem", item.Id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el item para modificar.";
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

        public List<Item> ObtenerTodo()
        {
            List<Item> listaItems = new List<Item>();
            string query = "SELECT * FROM items";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaItems.Add(Map(reader));
                        }
                    }
                }
            }
            catch (OracleException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return listaItems;
        }

        public List<Item> ObtenerItemsPorFactura(string idFactura)
        {
            List<Item> listaItems = new List<Item>();
            string query = "SELECT * FROM items WHERE ID_FACTURA = :IdFactura";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdFactura", idFactura));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaItems.Add(Map(reader));
                        }
                    }
                }
            }
            catch (OracleException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return listaItems;
        }

        private Item Map(OracleDataReader reader)
        {
            Juego juego = new RepositorioJuegos().BuscarPorId(Convert.ToString(reader["ID_JUEGO"]));
            return new Item(
                Convert.ToString(reader["ID"]),
                juego,
                Convert.ToInt32(reader["CANTIDAD"])
            );
        }
    }
}