using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioUsuarios : ConexionOracle
    {
        RepositorioTiposDocumentos repositorioTiposDocumentos = new RepositorioTiposDocumentos();
        RepositorioRoles repositorioRoles = new RepositorioRoles();

        public string Registrar(Usuario usuario)
        {
            string query = "INSERT INTO USUARIOS (NUMERO_DOCUMENTO, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, TELEFONO, CORREO_ELECTRONICO, TIPO_PERSONA, NOMBRE_USUARIO, CONTRASENIA, ID_TIPO_DOCUMENTO, ID_ROL) VALUES (:NumeroDocumento, :PrimerNombre, :SegundoNombre, :PrimerApellido, :SegundoApellido, :Telefono, :CorreoElectronico, :TipoPersona, :NombreUsuario, :Contrasenia, :IdTipoDocumento, :IdRol)";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", usuario.NumeroIdentificacion));
                    command.Parameters.Add(new OracleParameter("PrimerNombre", usuario.PrimerNombre));
                    command.Parameters.Add(new OracleParameter("SegundoNombre", usuario.SegundoNombre));
                    command.Parameters.Add(new OracleParameter("PrimerApellido", usuario.PrimerApellido));
                    command.Parameters.Add(new OracleParameter("SegundoApellido", usuario.SegundoApellido));
                    command.Parameters.Add(new OracleParameter("Telefono", usuario.Telefono));
                    command.Parameters.Add(new OracleParameter("CorreoElectronico", usuario.CorreoElectronico));
                    command.Parameters.Add(new OracleParameter("TipoPersona", usuario.TipoPersona));
                    command.Parameters.Add(new OracleParameter("NombreUsuario", usuario.NombreUsuario));
                    command.Parameters.Add(new OracleParameter("Contrasenia", usuario.Contrasenia));
                    command.Parameters.Add(new OracleParameter("IdTipoDocumento", usuario.TipoDocumento.Id));
                    command.Parameters.Add(new OracleParameter("IdRol", usuario.Rol.Id));
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
            finally
            {
                CerrarConexion();
            }
        }

        public Usuario BuscarPorId(string numeroDocumento)
        {
            Usuario usuario = null;
            string query = "SELECT * FROM USUARIOS WHERE NUMERO_DOCUMENTO = :NumeroDocumento";

            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", numeroDocumento));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = Map(reader);
                        }
                    }
                }
            }
            catch (OracleException)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return usuario;
        }

        public string Modificar(Usuario usuario)
        {
            string query = "UPDATE USUARIOS SET PRIMER_NOMBRE = :PrimerNombre, SEGUNDO_NOMBRE = :SegundoNombre, PRIMER_APELLIDO = :PrimerApellido, SEGUNDO_APELLIDO = :SegundoApellido, TELEFONO = :Telefono, CORREO_ELECTRONICO = :CorreoElectronico, TIPO_PERSONA = :TipoPersona, NOMBRE_USUARIO = :NombreUsuario, CONTRASENIA = :Contrasenia, ID_TIPO_DOCUMENTO = :IdTipoDocumento, ID_ROL = :IdRol WHERE NUMERO_DOCUMENTO = :NumeroDocumento";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("PrimerNombre", usuario.PrimerNombre));
                    command.Parameters.Add(new OracleParameter("SegundoNombre", usuario.SegundoNombre));
                    command.Parameters.Add(new OracleParameter("PrimerApellido", usuario.PrimerApellido));
                    command.Parameters.Add(new OracleParameter("SegundoApellido", usuario.SegundoApellido));
                    command.Parameters.Add(new OracleParameter("Telefono", usuario.Telefono));
                    command.Parameters.Add(new OracleParameter("CorreoElectronico", usuario.CorreoElectronico));
                    command.Parameters.Add(new OracleParameter("TipoPersona", usuario.TipoPersona));
                    command.Parameters.Add(new OracleParameter("NombreUsuario", usuario.NombreUsuario));
                    command.Parameters.Add(new OracleParameter("Contrasenia", usuario.Contrasenia));
                    command.Parameters.Add(new OracleParameter("IdTipoDocumento", usuario.TipoDocumento.Id));
                    command.Parameters.Add(new OracleParameter("IdRol", usuario.Rol.Id));
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", usuario.NumeroIdentificacion));

                    if (command.ExecuteNonQuery() == 0)
                    {
                        return "No se encontró el usuario para modificar.";
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
            finally
            {
                CerrarConexion();
            }
        }

        public string Eliminar(string numeroDocumento)
        {
            string query = "DELETE FROM USUARIOS WHERE NUMERO_DOCUMENTO = :NumeroDocumento";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", numeroDocumento));
                    if (command.ExecuteNonQuery() == 0)
                    {
                        return "No se encontró el usuario para eliminar.";
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
            finally
            {
                CerrarConexion();
            }
        }

        public List<Usuario> ObtenerTodo()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string query = "SELECT * FROM USUARIOS";

            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaUsuarios.Add(Map(reader));
                        }
                    }
                }
            }
            catch (OracleException)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return listaUsuarios;
        }

        public Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            Usuario usuario = null;
            string query = "SELECT * FROM USUARIOS WHERE NOMBRE_USUARIO = :NombreUsuario";

            try
            {
                AbrirConexion();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("NombreUsuario", nombreUsuario));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = Map(reader);
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
            return usuario;
        }

        private Usuario Map(OracleDataReader reader)
        {
            TipoDocumento tipoDocumento = repositorioTiposDocumentos.BuscarPorId(Convert.ToString(reader["ID_TIPO_DOCUMENTO"]));
            Rol rol = repositorioRoles.BuscarPorId(Convert.ToString(reader["ID_ROL"]));

            return new Usuario(
                Convert.ToString(reader["NUMERO_DOCUMENTO"]),
                tipoDocumento,
                Convert.ToString(reader["PRIMER_NOMBRE"]),
                Convert.ToString(reader["SEGUNDO_NOMBRE"]),
                Convert.ToString(reader["PRIMER_APELLIDO"]),
                Convert.ToString(reader["SEGUNDO_APELLIDO"]),
                Convert.ToString(reader["CORREO_ELECTRONICO"]),
                Convert.ToString(reader["TELEFONO"]),
                Convert.ToString(reader["TIPO_PERSONA"]),
                Convert.ToString(reader["NOMBRE_USUARIO"]),
                Convert.ToString(reader["CONTRASENIA"]),
                rol
            );
        }
    }
}