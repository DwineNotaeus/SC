using ServiciosSC.Core.DTOs;
using ServiciosSC.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiciosSC.Core.Interfaces
{
    public interface ICreditService
    {
        IEnumerable<string> GetListOfAllCredits();
        Task CreateCredit(CreditByClientDTO model);

        Task<IEnumerable<IdentificationTypeDTO>> GetListTypeDocument();
    }
}