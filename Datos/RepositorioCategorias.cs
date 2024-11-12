using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioCategorias : ConexionOracle
    {
        public string Eliminar(string id)
        {
            string query = "DELETE FROM CATEGORIAS WHERE ID = :IdCategoria";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdCategoria", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró la categoría para eliminar.";
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

        public Categoria BuscarPorId(string id)
        {
            Categoria categoria = null;
            string query = "SELECT * FROM CATEGORIAS WHERE ID = :IdCategoria";
            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdCategoria", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoria = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró la categoría con el ID proporcionado.");
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
            return categoria;
        }

        public string Modificar(Categoria categoria)
        {
            string query = "UPDATE CATEGORIAS SET DESCRIPCION = :Descripcion WHERE ID = :IdCategoria";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", categoria.Descripcion));
                    command.Parameters.Add(new OracleParameter("IdCategoria", categoria.Id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró la categoría para modificar.";
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

        public List<Categoria> ObtenerTodo()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            string query = "SELECT * FROM CATEGORIAS";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCategorias.Add(Map(reader));
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
            return listaCategorias;
        }

        public string Registrar(Categoria categoria)
        {
            string registro = "INSERT INTO CATEGORIAS (ID, DESCRIPCION) VALUES (:IdCategoria, :Descripcion)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(registro, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdCategoria", categoria.Id));
                    command.Parameters.Add(new OracleParameter("Descripcion", categoria.Descripcion));
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

        private Categoria Map(OracleDataReader reader)
        {
            return new Categoria(
                Convert.ToString(reader["ID"]),
                Convert.ToString(reader["DESCRIPCION"])
            );
        }
    }
}