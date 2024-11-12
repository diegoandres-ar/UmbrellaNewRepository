using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioFacturas : ConexionOracle
    {
        RepositorioClientes repositorioClientes = new RepositorioClientes();
        RepositorioMediosPago repositorioMediosPago = new RepositorioMediosPago();
        RepositorioUsuarios repositorioUsuarios = new RepositorioUsuarios();
        RepositorioItems repositorioItems = new RepositorioItems();
        public string Registrar(Factura factura)
        {
            string query = "INSERT INTO FACTURAS (ID, CEDULA_CLIENTE, CEDULA_USUARIO, FECHA, HORA, IVA, ID_MEDIO_PAGO, OBSERVACIONES, TOTAL, CODIGO_QR) " +
                           "VALUES (:IdFactura, :CedulaCliente, :CedulaUsuario, :Fecha, :Hora, :IVA, :IdMedioPago, :Observaciones, :Total, :CodigoQR)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdFactura", factura.Id));
                    command.Parameters.Add(new OracleParameter("CedulaCliente", factura.Cliente.NumeroIdentificacion));
                    command.Parameters.Add(new OracleParameter("CedulaUsuario", factura.Usuario.NumeroIdentificacion));
                    command.Parameters.Add(new OracleParameter("Fecha", factura.Fecha) { OracleDbType = OracleDbType.Date });
                    command.Parameters.Add(new OracleParameter("Hora", factura.Hora.ToString("HH:mm:ss")));
                    command.Parameters.Add(new OracleParameter("IVA", factura.IVA));
                    command.Parameters.Add(new OracleParameter("IdMedioPago", factura.MedioPago.Id));
                    command.Parameters.Add(new OracleParameter("Observaciones", factura.Observaciones));
                    command.Parameters.Add(new OracleParameter("Total", factura.Total));
                    command.Parameters.Add(new OracleParameter("CodigoQR", factura.CodigoQR));
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

        public Factura BuscarPorId(string id)
        {
            Factura factura = null;
            string query = "SELECT * FROM FACTURAS WHERE ID = :IdFactura";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdFactura", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            factura = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró la factura con el ID proporcionado.");
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
            return factura;
        }

        public string Modificar(Factura factura)
        {
            string query = "UPDATE FACTURAS SET CEDULA_CLIENTE = :CedulaCliente, CEDULA_USUARIO = :CedulaUsuario, FECHA = :Fecha, HORA = :Hora, " +
                           "IVA = :IVA, ID_MEDIO_PAGO = :IdMedioPago, OBSERVACIONES = :Observaciones, TOTAL = :Total, CODIGO_QR = :CodigoQR WHERE ID = :IdFactura";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdFactura", factura.Id));
                    command.Parameters.Add(new OracleParameter("CedulaCliente", factura.Cliente.NumeroIdentificacion));
                    command.Parameters.Add(new OracleParameter("CedulaUsuario", factura.Usuario.NumeroIdentificacion));
                    command.Parameters.Add(new OracleParameter("Fecha", factura.Fecha));
                    command.Parameters.Add(new OracleParameter("Hora", factura.Hora));
                    command.Parameters.Add(new OracleParameter("IVA", factura.IVA));
                    command.Parameters.Add(new OracleParameter("IdMedioPago", factura.MedioPago.Id));
                    command.Parameters.Add(new OracleParameter("Observaciones", factura.Observaciones));
                    command.Parameters.Add(new OracleParameter("Total", factura.Total));
                    command.Parameters.Add(new OracleParameter("CodigoQR", ConvertImageToBlob(factura.CodigoQR)));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró la factura para modificar.";
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

        public string Eliminar(string id)
        {
            string query = "DELETE FROM FACTURAS WHERE ID = :IdFactura";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdFactura", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró la factura para eliminar.";
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

        public List<Factura> ObtenerTodo()
        {
            List<Factura> listaFacturas = new List<Factura>();
            string query = "SELECT * FROM FACTURAS";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaFacturas.Add(Map(reader));
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
            return listaFacturas;
        }

        public Dictionary<DateTime, int> ObtenerFacturasPorDia(DateTime fechaInicio, DateTime fechaFin)
        {
            Dictionary<DateTime, int> facturasPorDia = new Dictionary<DateTime, int>();
            string query = "SELECT TRUNC(FECHA) AS DIA, COUNT(*) AS CANTIDAD " +
                           "FROM FACTURAS " +
                           "WHERE FECHA BETWEEN :FechaInicio AND :FechaFin " +
                           "GROUP BY TRUNC(FECHA) " +
                           "ORDER BY DIA";

            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("FechaInicio", fechaInicio));
                    command.Parameters.Add(new OracleParameter("FechaFin", fechaFin));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime dia = Convert.ToDateTime(reader["DIA"]);
                            int cantidad = Convert.ToInt32(reader["CANTIDAD"]);
                            facturasPorDia[dia] = cantidad;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error en la base de datos: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                CerrarConexion();
            }

            return facturasPorDia;
        }


        private byte[] ConvertImageToBlob(byte[] imageBytes)
        {
            return imageBytes;
        }

        private Factura Map(OracleDataReader reader)
        {
            Cliente cliente = repositorioClientes.BuscarPorId(Convert.ToString(reader["CEDULA_CLIENTE"]));
            MedioPago medioPago = repositorioMediosPago.BuscarPorId(Convert.ToString(reader["ID_MEDIO_PAGO"]));
            Usuario usuario = repositorioUsuarios.BuscarPorId(Convert.ToString(reader["CEDULA_USUARIO"]));
            List<Item> items = repositorioItems.ObtenerItemsPorFactura(Convert.ToString(reader["ID"]));

            return new Factura(
                Convert.ToString(reader["ID"]),
                cliente,
                usuario,
                Convert.ToDateTime(reader["FECHA"]),
                DateTime.ParseExact(reader["HORA"].ToString(), "HH:mm:ss", null),
                items,
                Convert.ToDouble(reader["IVA"]),
                medioPago,
                Convert.ToString(reader["OBSERVACIONES"]),
                reader["CODIGO_QR"] != DBNull.Value ? (byte[])reader["CODIGO_QR"] : null,
                Convert.ToDouble(reader["TOTAL"])
            );
        }
    }
}