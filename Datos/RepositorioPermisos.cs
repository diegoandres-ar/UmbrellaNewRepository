using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioPermisos : ConexionOracle
    {
        public string Eliminar(string id)
        {
            string query = "DELETE FROM PERMISOS WHERE ID = :IdPermiso";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdPermiso", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el permiso para eliminar.";
                    }
                }
                transaction.Commit();
                return "Permiso eliminado.";
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

        public Permiso BuscarPorId(string id)
        {
            Permiso permiso = null;
            string query = "SELECT * FROM PERMISOS WHERE ID = :IdPermiso";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdPermiso", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            permiso = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró el permiso con el ID proporcionado.");
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
            return permiso;
        }

        public string Modificar(Permiso permiso)
        {
            string query = "UPDATE PERMISOS SET DESCRIPCION = :Descripcion WHERE ID = :IdPermiso";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", permiso.Descripcion));
                    command.Parameters.Add(new OracleParameter("IdPermiso", permiso.Id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el permiso para modificar.";
                    }
                }
                transaction.Commit();
                return "Permiso modificado.";
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

        public List<Permiso> ObtenerTodo()
        {
            List<Permiso> listaPermisos = new List<Permiso>();
            string query = "SELECT * FROM PERMISOS";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaPermisos.Add(Map(reader));
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
            return listaPermisos;
        }

        public string Registrar(Permiso permiso)
        {
            string registro = "INSERT INTO PERMISOS (ID, DESCRIPCION) VALUES (:IdPermiso, :Descripcion)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(registro, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdPermiso", permiso.Id));
                    command.Parameters.Add(new OracleParameter("Descripcion", permiso.Descripcion));
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                return "Permiso registrado exitosamente.";
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

        private Permiso Map(OracleDataReader reader)
        {
            return new Permiso(
                Convert.ToString(reader["ID"]),
                Convert.ToString(reader["DESCRIPCION"])
            );
        }
    }
}