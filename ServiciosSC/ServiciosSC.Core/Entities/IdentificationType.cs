using System;
using System.Collections.Generic;

namespace ServiciosSC.Core.Entities
{
    public partial class IdentificationType
    {
        public IdentificationType()
        {
            Client = new HashSet<Client>();
        }

        public byte TipoIdentificacionId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
