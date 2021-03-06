using ServiciosSC.Core.DTOs;
using ServiciosSC.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiciosSC.Core.Interfaces
{
    public interface ICredit
    {
        Task CreateCredit(CreditByClientDTO model, bool status);
        Task<IEnumerable<IdentificationTypeDTO>> GetListTypeDocument();




        IEnumerable<string> GetListOfAllCredits();

    }
}