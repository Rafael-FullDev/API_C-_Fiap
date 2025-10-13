using Core.Entity;
using Core.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class EFRepository<T> : IRepository<T> where T : EntityBase/* IRepository<T> where T : EntityBase*/
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> _dbSet;

        public EFRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Alerar(T entidade)
        {
            _dbSet.Update(entidade);
            _context.SaveChanges();
        }

        public void Alerar(Task entidade)
        {
            throw new NotImplementedException();
        }

        public void Alterar(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(T entidade)
        {
            entidade.DataCriacao = DateTime.Now;
            _dbSet.Add(entidade);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            _dbSet.Remove(ObterPorId(id));
            _context.SaveChanges();
        }

        public IList<T> Lista()
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(int id)
            => _dbSet.FirstOrDefault(entity => entity.Id == id);

        public IList<T> ObterTodos()
            => _dbSet.ToList();
    }
}
