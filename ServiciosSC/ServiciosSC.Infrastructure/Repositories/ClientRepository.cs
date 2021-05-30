namespace ServiciosSC.Core.Interfaces
{
    using ServiciosSC.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using ServiciosSC.Core.Entities;
    using System.Threading.Tasks;
    using ServiciosSC.Core.Repositories;

    public class ClientRepository : IClientRepository
    {
        private readonly SCContext _context;
        public ClientRepository(SCContext context)
        {
            _context = context;
        }

       

        public async Task<Client> GetClient(string NroIdentificacion)
        {
            var client = await _context.Client.FirstOrDefaultAsync(x => x.NumeroIdentificacion == NroIdentificacion);
            return client;
        }
    }
}
