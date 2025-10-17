using Core.Entity;

namespace Core.IRepository
{
    public interface IRepository<T> where T : EntityBase
    {
        IList<T> Lista();
        T ObterPorId(int Id);
        void Cadastrar(T entidade);
        void Alterar(T entidade);
        void Deletar(int Id);

    }
}
