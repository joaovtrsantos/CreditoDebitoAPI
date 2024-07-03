using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace UnitTest.Infrastructure
{
    public class CreditDebitRepositoryTests
    {
        private CreditDebitContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<CreditDebitContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new CreditDebitContext(options);
        }

        [Fact]
        public async Task Add_CreditDebit_Success()
        {
            var context = GetDbContext();
            var repository = new CreditDebitRepository(context);

            var creditDebit = new CreditDebit
            {
                Value = 100,
                IsCreditOrDebit = Domain.Enumerators.CreditDebitType.Credit,
                TransactionDate = DateTime.Now
            };

            await repository.Add(creditDebit);

            var result = await context.CreditDebits.FindAsync(creditDebit.Id);

            Assert.NotNull(result);
            Assert.Equal(creditDebit.Id, result.Id);
        }

        [Fact]
        public async Task Delete_CreditDebit_Success()
        {
            var context = GetDbContext();
            var repository = new CreditDebitRepository(context);

            var creditDebit = new CreditDebit
            {
                Value = 100,
                IsCreditOrDebit = Domain.Enumerators.CreditDebitType.Credit,
                TransactionDate = DateTime.Now
            };

            context.CreditDebits.Add(creditDebit);
            await context.SaveChangesAsync();

            await repository.Delete(creditDebit.Id);

            var result = await context.CreditDebits.FindAsync(creditDebit.Id);

            Assert.Null(result);
        }

        [Fact]
        public async Task GetAll_CreditDebits_Success()
        {
            var context = GetDbContext();
            var repository = new CreditDebitRepository(context);

            var creditDebit1 = new CreditDebit
            {
                Value = 100,
                IsCreditOrDebit = Domain.Enumerators.CreditDebitType.Credit,
                TransactionDate = DateTime.Now
            };

            var creditDebit2 = new CreditDebit
            {
                Value = 200,
                IsCreditOrDebit = Domain.Enumerators.CreditDebitType.Debit,
                TransactionDate = DateTime.Now
            };

            context.CreditDebits.AddRange(creditDebit1, creditDebit2);
            await context.SaveChangesAsync();

            var result = await repository.GetAll();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task GetById_CreditDebit_Success()
        {
            var context = GetDbContext();
            var repository = new CreditDebitRepository(context);

            var creditDebit = new CreditDebit
            {
                Value = 100,
                IsCreditOrDebit = Domain.Enumerators.CreditDebitType.Credit,
                TransactionDate = DateTime.Now
            };

            context.CreditDebits.Add(creditDebit);
            await context.SaveChangesAsync();

            var result = await repository.GetById(creditDebit.Id);

            Assert.NotNull(result);
            Assert.Equal(creditDebit.Id, result.Id);
        }

        [Fact]
        public async Task Update_CreditDebit_Success()
        {
            var context = GetDbContext();
            var repository = new CreditDebitRepository(context);

            var creditDebit = new CreditDebit
            {
                Value = 100,
                IsCreditOrDebit = Domain.Enumerators.CreditDebitType.Credit,
                TransactionDate = DateTime.Now
            };

            context.CreditDebits.Add(creditDebit);
            await context.SaveChangesAsync();

            creditDebit.Value = 200;
            await repository.Update(creditDebit);

            var result = await context.CreditDebits.FindAsync(creditDebit.Id);

            Assert.NotNull(result);
            Assert.Equal(200, result.Value);
        }

        [Fact]
        public async Task GetDailyBalance_ReturnsCorrectRecords()
        {
            var options = new DbContextOptionsBuilder<CreditDebitContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using (var arrangeContext = new CreditDebitContext(options))
            {
                arrangeContext.CreditDebits.AddRange(
                    new CreditDebit { Value = 100, TransactionDate = DateTime.Now.AddDays(-1) },
                    new CreditDebit { Value = 200, TransactionDate = DateTime.Now.AddDays(-3) },
                    new CreditDebit { Value = 300, TransactionDate = DateTime.Now.AddDays(-10) }
                );
                arrangeContext.SaveChanges();
            }

            using (var context = new CreditDebitContext(options))
            {
                var repository = new CreditDebitRepository(context);
                var daysAgo = 7;
                var result = await repository.GetDailyBalance(daysAgo);
                Assert.Equal(2, result.Count);
            }
        }
    }
}
