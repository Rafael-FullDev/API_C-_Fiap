using Core.Entity;
using Core.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class EFRepository<T> : IRepository<T> where T : EntityBase
    {
        protected ApplicationDBContext _context;
        protected DbSet<T> _dbSet;

        public EFRepository(ApplicationDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Alterar(T entidade)
        {
            _dbSet.Update(entidade);
            _context.SaveChanges();
        }

        public void Cadastrar(T entidade)
        {
            entidade.DataCriacao = DateTime.Now;
            _dbSet.Add(entidade);
            _context.SaveChanges();
        }

        public void Deletar(int Id)
        {
            _dbSet.Remove(ObterPorId(Id));
            _context.SaveChanges();
        }

        public IList<T> Lista()
            => _dbSet.ToList();


        public T ObterPorId(int Id)
        => _dbSet.FirstOrDefault(entity => entity.Id == Id);
    }
}
