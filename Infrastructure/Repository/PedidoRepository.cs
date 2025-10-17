using Core.Entity;
using Core.IRepository;
namespace Infrastructure.Repository
{
    public class PedidoRepository : EFRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationDBContext context) : base(context)
        {
        }

        public void Alterar(Livro entidade)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Livro entidade)
        {
            throw new NotImplementedException();
        }

        IList<Livro> IRepository<Livro>.Lista()
        {
            throw new NotImplementedException();
        }

        Livro IRepository<Livro>.ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
