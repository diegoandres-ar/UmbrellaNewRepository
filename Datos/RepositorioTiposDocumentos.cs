using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioTiposDocumentos : ConexionOracle
    {
        public string Eliminar(string id)
        {
            string query = "DELETE FROM TIPOS_DE_DOCUMENTO WHERE ID = :IdTipoDoc";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdTipoDoc", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el tipo de documento para eliminar.";
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

        public TipoDocumento BuscarPorId(string id)
        {
            TipoDocumento tipoDocumento = null;
            string query = "SELECT * FROM TIPOS_DE_DOCUMENTO WHERE ID = :IdTipoDoc";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdTipoDoc", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipoDocumento = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró el tipo de documento con el ID proporcionado.");
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
            return tipoDocumento;
        }

        public string Modificar(TipoDocumento tipoDocumento)
        {
            string query = "UPDATE TIPOS_DE_DOCUMENTO SET DESCRIPCION = :Descripcion WHERE ID = :IdTipoDoc";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", tipoDocumento.Descripcion));
                    command.Parameters.Add(new OracleParameter("IdTipoDoc", tipoDocumento.Id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el tipo de documento para modificar.";
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

        public List<TipoDocumento> ObtenerTodo()
        {
            List<TipoDocumento> listaTiposDocumentos = new List<TipoDocumento>();
            string query = "SELECT * FROM TIPOS_DE_DOCUMENTO";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaTiposDocumentos.Add(Map(reader));
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
            return listaTiposDocumentos;
        }

        public string Registrar(TipoDocumento tipoDocumento)
        {
            string registro = "INSERT INTO TIPOS_DE_DOCUMENTO (ID, DESCRIPCION) VALUES (:IdTipoDoc, :Descripcion)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(registro, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdTipoDoc", tipoDocumento.Id));
                    command.Parameters.Add(new OracleParameter("Descripcion", tipoDocumento.Descripcion));
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

        private TipoDocumento Map(OracleDataReader reader)
        {
            return new TipoDocumento(
                Convert.ToString(reader["ID"]),
                Convert.ToString(reader["DESCRIPCION"])
            );
        }
    }
}