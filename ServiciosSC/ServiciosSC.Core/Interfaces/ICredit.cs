using ServiciosSC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosSC.Core.Interfaces
{
    public interface ICredit
    {
        IEnumerable<string> GetListOfAllCredits();
        Task<IEnumerable<Credit>> GetCreditById();
    }
}