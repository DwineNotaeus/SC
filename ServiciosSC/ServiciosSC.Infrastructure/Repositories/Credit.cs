using ServiciosSC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosSC.Infrastructure.Repositories
{
    public class Credit : ICredit
    {
        public Task<IEnumerable<Core.Entities.Credit>> GetCreditById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetListOfAllCredits()
        {
            return new string[] { "value1", "value2", "value3" };
        }
    }
}
