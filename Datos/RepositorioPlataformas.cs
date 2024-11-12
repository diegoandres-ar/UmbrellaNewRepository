using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioPlataformas : ConexionOracle
    {
        public string Eliminar(string id)
        {
            string query = "DELETE FROM PLATAFORMAS WHERE ID = :IdPlataforma";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdPlataforma", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró la plataforma para eliminar.";
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

        public Plataforma BuscarPorId(string id)
        {
            Plataforma plataforma = null;
            string query = "SELECT * FROM PLATAFORMAS WHERE ID = :IdPlataforma";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdPlataforma", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            plataforma = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró la plataforma con el ID proporcionado.");
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
            return plataforma;
        }

        public string Modificar(Plataforma plataforma)
        {
            string query = "UPDATE PLATAFORMAS SET DESCRIPCION = :Descripcion WHERE ID = :IdPlataforma";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", plataforma.Descripcion));
                    command.Parameters.Add(new OracleParameter("IdPlataforma", plataforma.Id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró la plataforma para modificar.";
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

        public List<Plataforma> ObtenerTodo()
        {
            List<Plataforma> listaPlataformas = new List<Plataforma>();
            string query = "SELECT * FROM PLATAFORMAS";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaPlataformas.Add(Map(reader));
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
            return listaPlataformas;
        }

        public string Registrar(Plataforma plataforma)
        {
            string registro = "INSERT INTO PLATAFORMAS (ID, DESCRIPCION) VALUES (:IdPlataforma, :Descripcion)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(registro, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdPlataforma", plataforma.Id));
                    command.Parameters.Add(new OracleParameter("Descripcion", plataforma.Descripcion));
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

        private Plataforma Map(OracleDataReader reader)
        {
            return new Plataforma(
                Convert.ToString(reader["ID"]),
                Convert.ToString(reader["DESCRIPCION"])
            );
        }
    }
}