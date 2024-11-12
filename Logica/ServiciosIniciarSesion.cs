using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosIniciarSesion
    {
        RepositorioUsuarios repositorioUsuarios;

        public ServiciosIniciarSesion()
        {
            repositorioUsuarios = new RepositorioUsuarios();
        }

        public Usuario IniciarSesion(string nombreUsuario, string contrasena)
        {
            Usuario usuario = ObtenerPorNombreUsuario(nombreUsuario);
            if (usuario != null && usuario.Contrasenia == contrasena)
            {
                return usuario;
            }

            return null;
        }

        public Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            return repositorioUsuarios.ObtenerPorNombreUsuario(nombreUsuario);
        }
    }
}
