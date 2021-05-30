using ServiciosSC.Core.Entities;
using System.Threading.Tasks;

namespace ServiciosSC.Core.Repositories
{
    public interface IClientRepository
    {
        Task<Client> GetClient(string NroIdentificacion);
    }
}