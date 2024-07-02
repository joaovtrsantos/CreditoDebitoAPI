using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class CreditDebitRepository : ICreditDebitRepository
    {
        private readonly CreditDebitContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public CreditDebitRepository(CreditDebitContext creditDebitContext)
        {
            _context = creditDebitContext;
        }

        public async Task Add(CreditDebit creditDebit)
        {
            await _context.AddAsync(creditDebit);
            await SaveChanges();
        }

        public async Task Delete(Guid id)
        {
            var creditDebitToBeDeleted = await GetById(id);
            _context.Remove(creditDebitToBeDeleted);
            await SaveChanges();
        }

        public async Task<List<CreditDebit>> GetAll()
        {
            return await _context.CreditDebits.ToListAsync();
        }

        public async Task<CreditDebit> GetById(Guid id)
        {
            return await _context.CreditDebits.SingleAsync(x => x.Id == id);
        }

        public async Task Update(CreditDebit creditDebit)
        {
            _context.CreditDebits.Update(creditDebit);
            await SaveChanges();
        }

        private Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
