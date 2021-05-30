using AutoMapper;
using ServiciosSC.Core.DTOs;
using ServiciosSC.Core.Entities;
using ServiciosSC.Core.Interfaces;
using ServiciosSC.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServiciosSC.Infrastructure.Repositories
{
    public class CreditRepository : ICredit
    {
        private readonly SCContext _context;
        private readonly IMapper _mapper;

        public CreditRepository(SCContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateCredit(CreditByClientDTO model, bool status)
        {
            Credit credit = _mapper.Map<Credit>(model.EntityCredit);
            Client client = _mapper.Map<Client>(model.EntityClient);


            if (status != true)
            {
                _context.Client.Add(client);
            }
            else
            {
                client.ClienteId = int.Parse(model.EntityClient.NumeroIdentificacion);
            }

            _context.Credit.Add(credit);
            await _context.SaveChangesAsync();

            CreditByClient association = new CreditByClient
            {
                CreditId = credit.CreditoId,
                ClientId = client.ClienteId
            };

            _context.CreditByClient.Add(association);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<string> GetListOfAllCredits()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        public async Task<IEnumerable<IdentificationTypeDTO>> GetListTypeDocument()
        {
            return (IEnumerable<IdentificationTypeDTO>)await _context.IdentificationType.ToListAsync();
            
       
        }
    }
}
