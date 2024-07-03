using Application.Requests;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Repositories;

namespace Application.UseCases.CreditDebits
{
    public interface IGetCreditDebitsUseCase
    {
        Task<List<CreditDebit>> Execute();
    }
    public class GetCreditDebitsUseCase(ICreditDebitRepository creditDebitRepository) : IGetCreditDebitsUseCase
    {
        private readonly ICreditDebitRepository _creditDebitRepository = creditDebitRepository;

        public async Task<List<CreditDebit>> Execute()
        {
            return await _creditDebitRepository.GetAll();
        }
    }
}
