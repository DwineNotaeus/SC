using System;
using System.Collections.Generic;
using System.Text;

namespace ServiciosSC.Core.Entities
{
    public class Client
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public char TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string DireccíonResidencia { get; set; }
        public string Ubicacion { get; set; }
    }
}