using Domain.Entities;
using Domain.Interfaces.Generics;

namespace Domain.Interfaces
{
    public interface ICreditDebitRepository : IRepository<CreditDebit>
    {
        Task Add(CreditDebit creditDebit);
        Task<List<CreditDebit>> GetAll();
        Task<CreditDebit> GetById(Guid id);
        Task Update(CreditDebit creditDebit);
        Task Delete(Guid id);
    }
}
