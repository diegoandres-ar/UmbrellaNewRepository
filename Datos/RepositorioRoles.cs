using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioRoles : ConexionOracle
    {
        RepositorioPermisos repositorioPermisos = new RepositorioPermisos();

        public string Registrar(Rol rol)
        {
            string query = "INSERT INTO ROLES (ID, DESCRIPCION) VALUES (:IdRol, :Descripcion)";
            string queryRelacion = "INSERT INTO ROLES_PERMISOS (ID_ROL, ID_PERMISO) VALUES (:IdRol, :IdPermiso)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdRol", rol.Id));
                    command.Parameters.Add(new OracleParameter("Descripcion", rol.Descripcion));
                    command.ExecuteNonQuery();
                }

                foreach (var permiso in rol.Permisos)
                {
                    using (OracleCommand command = new OracleCommand(queryRelacion, conexion))
                    {
                        command.Parameters.Add(new OracleParameter("IdRol", rol.Id));
                        command.Parameters.Add(new OracleParameter("IdPermiso", permiso.Id));
                        command.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return "Rol registrado con éxito.";
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

        public Rol BuscarPorId(string id)
        {
            Rol rol = null;
            string query = "SELECT * FROM ROLES WHERE ID = :IdRol";
            string queryPermisos = "SELECT ID_PERMISO FROM ROLES_PERMISOS WHERE ID_ROL = :IdRol";
            try
            {
                AbrirConexion();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdRol", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rol = new Rol(
                                Convert.ToString(reader["ID"]),
                                Convert.ToString(reader["DESCRIPCION"]),
                                new List<Permiso>()
                            );
                        }
                        else
                        {
                            throw new Exception("No se encontró el rol con el ID proporcionado.");
                        }
                    }
                }

                using (OracleCommand command = new OracleCommand(queryPermisos, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdRol", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string permisoId = Convert.ToString(reader["ID_PERMISO"]);
                            Permiso permiso = repositorioPermisos.BuscarPorId(permisoId);
                            if (permiso != null)
                            {
                                rol.Permisos.Add(permiso);
                            }
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
            return rol;
        }

        public string Modificar(Rol rol)
        {
            string query = "UPDATE ROLES SET DESCRIPCION = :Descripcion WHERE ID = :IdRol";
            string queryBorrarRelaciones = "DELETE FROM ROLES_PERMISOS WHERE ID_ROL = :IdRol";
            string queryAgregarRelacion = "INSERT INTO ROLES_PERMISOS (ID_ROL, ID_PERMISO) VALUES (:IdRol, :IdPermiso)";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", rol.Descripcion));
                    command.Parameters.Add(new OracleParameter("IdRol", rol.Id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el rol para modificar.";
                    }
                }

                using (OracleCommand command = new OracleCommand(queryBorrarRelaciones, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdRol", rol.Id));
                    command.ExecuteNonQuery();
                }

                foreach (var permiso in rol.Permisos)
                {
                    using (OracleCommand command = new OracleCommand(queryAgregarRelacion, conexion))
                    {
                        command.Parameters.Add(new OracleParameter("IdRol", rol.Id));
                        command.Parameters.Add(new OracleParameter("IdPermiso", permiso.Id));
                        command.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return "Rol modificado con éxito.";
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
            string query = "DELETE FROM ROLES WHERE ID = :IdRol";
            string queryBorrarRelaciones = "DELETE FROM ROLES_PERMISOS WHERE ID_ROL = :IdRol";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(queryBorrarRelaciones, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdRol", id));
                    command.ExecuteNonQuery();
                }

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("IdRol", id));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el rol para eliminar.";
                    }
                }

                transaction.Commit();
                return "Rol eliminado con éxito.";
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

        public List<Rol> ObtenerTodo()
        {
            List<Rol> listaRoles = new List<Rol>();
            string query = "SELECT * FROM ROLES";
            string queryPermisos = "SELECT ID_PERMISO FROM ROLES_PERMISOS WHERE ID_ROL = :IdRol";

            try
            {
                AbrirConexion();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string rolId = Convert.ToString(reader["ID"]);
                            Rol rol = new Rol(
                                rolId,
                                Convert.ToString(reader["DESCRIPCION"]),
                                new List<Permiso>()
                            );

                            using (OracleCommand commandPermisos = new OracleCommand(queryPermisos, conexion))
                            {
                                commandPermisos.Parameters.Add(new OracleParameter("IdRol", rolId));
                                using (OracleDataReader permisosReader = commandPermisos.ExecuteReader())
                                {
                                    while (permisosReader.Read())
                                    {
                                        string permisoId = Convert.ToString(permisosReader["ID_PERMISO"]);
                                        Permiso permiso = repositorioPermisos.BuscarPorId(permisoId);
                                        if (permiso != null)
                                        {
                                            rol.Permisos.Add(permiso);
                                        }
                                    }
                                }
                            }
                            listaRoles.Add(rol);
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

            return listaRoles;
        }
    }
}