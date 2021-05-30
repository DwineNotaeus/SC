using System;
using System.Collections.Generic;

namespace ServiciosSC.Core.Entities
{
    public partial class CreditByClient
    {
        public int Id { get; set; }
        public int CreditId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Credit Credit { get; set; }
    }
}
