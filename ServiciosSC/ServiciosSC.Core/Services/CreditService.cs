using ServiciosSC.Core.DTOs;
using ServiciosSC.Core.Entities;
using ServiciosSC.Core.Interfaces;
using ServiciosSC.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosSC.Core.Services
{
    public class CreditService : ICreditService
    {
        private readonly ICredit _credit;
        private readonly IClientRepository _clientRepository;

        public CreditService(ICredit credit, IClientRepository clientRepository)
        {
            _credit = credit;
            _clientRepository = clientRepository;
        }


        public IEnumerable<string> GetListOfAllCredits()
        {
            return _credit.GetListOfAllCredits();
        }

        public async Task CreateCredit(CreditByClientDTO model)
        {
            bool status = false;
            var idClient = _clientRepository.GetClient(model.EntityClient.NumeroIdentificacion);
            if (idClient.Result != null)
            {
                model.EntityClient.NumeroIdentificacion = idClient.Result.ClienteId.ToString();
                status = true;
            }
            await _credit.CreateCredit(model, status);
        }

        public async Task<IEnumerable<IdentificationTypeDTO>> GetListTypeDocument()
        {
            return await _credit.GetListTypeDocument();
        }
    }
}
