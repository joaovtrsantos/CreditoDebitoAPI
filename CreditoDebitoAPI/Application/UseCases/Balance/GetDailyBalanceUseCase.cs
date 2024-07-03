using Application.Response;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Balance
{
    public interface IGetDailyBalanceUseCase
    {
        Task<List<GetDailyBalanceResponse>> Execute(int days);

    }
    public class GetDailyBalanceUseCase : IGetDailyBalanceUseCase
    {
        private readonly ICreditDebitRepository _creditDebitRepository;

        public GetDailyBalanceUseCase(ICreditDebitRepository creditDebitRepository)
        {
            _creditDebitRepository = creditDebitRepository;
        }

        public async Task<List<GetDailyBalanceResponse>> Execute(int days)
        {
            var creditDebitList = await _creditDebitRepository.GetDailyBalance(days);

            var groupedByDate = creditDebitList
                .GroupBy(cd => cd.TransactionDate.Date)
                .Select(g => new GetDailyBalanceResponse(
                    DateOnly.FromDateTime(g.Key),
                    g.Sum(cd => cd.IsCreditOrDebit == Domain.Enumerators.CreditDebitType.Credit ? -cd.Value : cd.Value)
                ))
                .ToList();

            return groupedByDate;
        }
    }
}
