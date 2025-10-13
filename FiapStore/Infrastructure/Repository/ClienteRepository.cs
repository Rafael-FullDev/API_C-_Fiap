using Core.Entity;
using Core.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Cliente ObterPedidosSeisMeses(int id)
        {
            var cliente = _context.Cliente
                .Include(c => c.Pedidos)
                .ThenInclude(p => p.Livro)
                .FirstOrDefault(c => c.Id == id)
                ?? throw new Exception("Esse cliente não exite");

            cliente.Pedidos = cliente.Pedidos.Where(c => c.DataCriacao >= DateTime.Now.AddMonths(-6))
                .Select(p =>
                {
                    p.Cliente = null;
                    p.Livro.Pedidos = null;
                    return p;
                }
                )
                .ToList();

            return cliente;
        }
    }
}
