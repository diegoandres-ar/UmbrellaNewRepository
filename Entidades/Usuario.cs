using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public Rol Rol { get; set; }
        public Usuario(string numeroIdentificacion, TipoDocumento tipoDocumento, string primerNombre,
            string segundoNombre, string primerApellido, string segundoApellido, string correoElectronico,
            string telefono, string tipoPersona, string nombreUsuario, string contrasenia, Rol rol)
        {
            NumeroIdentificacion = numeroIdentificacion;
            TipoDocumento = tipoDocumento;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            TipoPersona = tipoPersona;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Rol = rol;
        }

    }
}
