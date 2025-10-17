using Core.Entity;
using Core.IRepository;
namespace Infrastructure.Repository
{
    public class LivroRepository : EFRepository<Livro>, ILivroRepository
    {
        public LivroRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
