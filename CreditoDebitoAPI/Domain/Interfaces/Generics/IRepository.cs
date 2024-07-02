

namespace Domain.Interfaces.Generics
{
    public interface IRepository<T>
    {
        public IUnitOfWork UnitOfWork { get; }
    }
}
