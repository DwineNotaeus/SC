using System;
using System.Collections.Generic;
using System.Text;

namespace ServiciosSC.Core.Entities
{
    public class Credit
    {
        public int CreditoId { get; set; }
        public decimal ValorTotalCredito { get; set; }
        public int NumeroCuotas { get; set; }
    }
}
