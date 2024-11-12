using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioMediosPago : ConexionOracle
    {
        public string Registrar(MedioPago medioPago)
        {
            string query = "INSERT INTO medios_de_pago (ID, DESCRIPCION) VALUES (:IdMedioPago, :Descripcion)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdMedioPago", medioPago.Id));
                    command.Parameters.Add(new OracleParameter("Descripcion", medioPago.Descripcion));
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
            string query = "DELETE FROM medios_de_pago WHERE ID = :IdMedioPago";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdMedioPago", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el medio de pago para eliminar.";
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

        public MedioPago BuscarPorId(string id)
        {
            MedioPago medioPago = null;
            string query = "SELECT * FROM medios_de_pago WHERE ID = :IdMedioPago";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdMedioPago", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            medioPago = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró el medio de pago con el ID proporcionado.");
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
            return medioPago;
        }

        public string Modificar(MedioPago medioPago)
        {
            string query = "UPDATE medios_de_pago SET DESCRIPCION = :Descripcion WHERE ID = :IdMedioPago";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", medioPago.Descripcion));
                    command.Parameters.Add(new OracleParameter("IdMedioPago", medioPago.Id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el medio de pago para modificar.";
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

        public List<MedioPago> ObtenerTodo()
        {
            List<MedioPago> listaMediosPago = new List<MedioPago>();
            string query = "SELECT * FROM medios_de_pago";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaMediosPago.Add(Map(reader));
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
            return listaMediosPago;
        }

        private MedioPago Map(OracleDataReader reader)
        {
            return new MedioPago(
                Convert.ToString(reader["ID"]),
                Convert.ToString(reader["DESCRIPCION"])
            );
        }
    }
}