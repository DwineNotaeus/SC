using System;
using System.Collections.Generic;

namespace ServiciosSC.Core.Entities
{
    public partial class Credit
    {
        public Credit()
        {
            CreditByClient = new HashSet<CreditByClient>();
        }

        public int CreditoId { get; set; }
        public decimal ValorTotalCredito { get; set; }
        public int NumeroCuotas { get; set; }

        public virtual ICollection<CreditByClient> CreditByClient { get; set; }
    }
}
