using System;
using System.Collections.Generic;

namespace ServiciosSC.Core.Entities
{
    public partial class Client
    {
        public Client()
        {
            CreditByClient = new HashSet<CreditByClient>();
        }

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public byte TipoIdentificacionId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string DireccionResidencia { get; set; }
        public string Ubicacion { get; set; }

        public virtual IdentificationType TipoIdentificacion { get; set; }
        public virtual ICollection<CreditByClient> CreditByClient { get; set; }
    }
}
