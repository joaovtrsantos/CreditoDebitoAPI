using Domain.Entities;
using Domain.Interfaces.Generics;
using Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Data
{
    public class CreditDebitContext : DbContext, IUnitOfWork
    {
        public CreditDebitContext(DbContextOptions<CreditDebitContext> options) : base(options)
        {

        }

        public DbSet<CreditDebit> CreditDebits { get; set; }
    }
}
