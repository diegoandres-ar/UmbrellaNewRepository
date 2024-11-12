using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class RepositorioClientes : ConexionOracle
    {
        RepositorioTiposDocumentos repositorioTiposDocumentos = new RepositorioTiposDocumentos();
        public string Registrar(Cliente cliente)
        {
            string query = "INSERT INTO CLIENTES (NUMERO_DOCUMENTO, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, TELEFONO, CORREO_ELECTRONICO, TIPO_PERSONA, ID_TIPO_DOCUMENTO) VALUES (:NumeroDocumento, :PrimerNombre, :SegundoNombre, :PrimerApellido, :SegundoApellido, :Telefono, :CorreoElectronico, :TipoPersona, :IdTipoDocumento)";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", cliente.NumeroIdentificacion));
                    command.Parameters.Add(new OracleParameter("PrimerNombre", cliente.PrimerNombre));
                    command.Parameters.Add(new OracleParameter("SegundoNombre", cliente.SegundoNombre));
                    command.Parameters.Add(new OracleParameter("PrimerApellido", cliente.PrimerApellido));
                    command.Parameters.Add(new OracleParameter("SegundoApellido", cliente.SegundoApellido));
                    command.Parameters.Add(new OracleParameter("Telefono", cliente.Telefono));
                    command.Parameters.Add(new OracleParameter("CorreoElectronico", cliente.CorreoElectronico));
                    command.Parameters.Add(new OracleParameter("TipoPersona", cliente.TipoPersona));
                    command.Parameters.Add(new OracleParameter("IdTipoDocumento", cliente.TipoDocumento.Id));
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

        public Cliente BuscarPorId(string numeroDocumento)
        {
            Cliente cliente = null;
            string query = "SELECT * FROM CLIENTES WHERE NUMERO_DOCUMENTO = :NumeroDocumento";
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
                            cliente = Map(reader);
                        }
                        else
                        {
                            throw new Exception("No se encontró el cliente con el número de documento proporcionado.");
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
            return cliente;
        }

        public string Modificar(Cliente cliente)
        {
            string query = "UPDATE CLIENTES SET PRIMER_NOMBRE = :PrimerNombre, SEGUNDO_NOMBRE = :SegundoNombre, PRIMER_APELLIDO = :PrimerApellido, SEGUNDO_APELLIDO = :SegundoApellido, TELEFONO = :Telefono, CORREO_ELECTRONICO = :CorreoElectronico, TIPO_PERSONA = :TipoPersona, ID_TIPO_DOCUMENTO = :IdTipoDocumento WHERE NUMERO_DOCUMENTO = :NumeroDocumento";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("PrimerNombre", cliente.PrimerNombre));
                    command.Parameters.Add(new OracleParameter("SegundoNombre", cliente.SegundoNombre));
                    command.Parameters.Add(new OracleParameter("PrimerApellido", cliente.PrimerApellido));
                    command.Parameters.Add(new OracleParameter("SegundoApellido", cliente.SegundoApellido));
                    command.Parameters.Add(new OracleParameter("Telefono", cliente.Telefono));
                    command.Parameters.Add(new OracleParameter("CorreoElectronico", cliente.CorreoElectronico));
                    command.Parameters.Add(new OracleParameter("TipoPersona", cliente.TipoPersona));
                    command.Parameters.Add(new OracleParameter("IdTipoDocumento", cliente.TipoDocumento.Id));
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", cliente.NumeroIdentificacion));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el cliente para modificar.";
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

        public string Eliminar(string numeroDocumento)
        {
            string query = "DELETE FROM CLIENTES WHERE NUMERO_DOCUMENTO = :NumeroDocumento";
            OracleTransaction transaction = null;
            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", numeroDocumento));
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return "No se encontró el cliente para eliminar.";
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

        public List<Cliente> ObtenerTodo()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            string query = "SELECT * FROM CLIENTES";
            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaClientes.Add(Map(reader));
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
            return listaClientes;
        }

        private Cliente Map(OracleDataReader reader)
        {
            TipoDocumento tipoDocumento = repositorioTiposDocumentos.BuscarPorId(Convert.ToString(reader["ID_TIPO_DOCUMENTO"]));

            return new Cliente(
                Convert.ToString(reader["NUMERO_DOCUMENTO"]),
                tipoDocumento,
                Convert.ToString(reader["PRIMER_NOMBRE"]),
                Convert.ToString(reader["SEGUNDO_NOMBRE"]),
                Convert.ToString(reader["PRIMER_APELLIDO"]),
                Convert.ToString(reader["SEGUNDO_APELLIDO"]),
                Convert.ToString(reader["CORREO_ELECTRONICO"]),
                Convert.ToString(reader["TELEFONO"]),
                Convert.ToString(reader["TIPO_PERSONA"])
            );
        }
    }
}