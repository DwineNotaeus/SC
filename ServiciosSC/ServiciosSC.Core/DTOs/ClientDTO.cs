using System;
using System.Collections.Generic;
using System.Text;

namespace ServiciosSC.Core.DTOs
{
    public class ClientDTO
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public byte TipoIdentificacionId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string DireccionResidencia { get; set; }
        public string Ubicacion { get; set; }
    }
}
