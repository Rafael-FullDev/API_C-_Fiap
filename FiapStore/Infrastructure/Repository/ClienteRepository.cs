using Core.Entity;
using Core.IRepository;

namespace Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDBContext context) : base(context)
        {

        }
    }
}
