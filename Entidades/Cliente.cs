using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        public Cliente(string numeroIdentificacion, TipoDocumento tipoDocumento, string primerNombre, 
            string segundoNombre, string primerApellido, string segundoApellido, string correoElectronico, 
            string telefono, string tipoPersona)
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
        }
    }
}
