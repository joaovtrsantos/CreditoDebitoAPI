using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.CreditDebits
{
    public interface IGetCreditDebitByIdUseCase
    {
        Task<CreditDebit> Execute(Guid id);
    }

    public class GetCreditDebitByIdUseCase : IGetCreditDebitByIdUseCase
    {
        private readonly ICreditDebitRepository _creditDebitRepository;

        public GetCreditDebitByIdUseCase(ICreditDebitRepository creditDebitRepository)
        {
            _creditDebitRepository = creditDebitRepository;
        }

        public async Task<CreditDebit> Execute(Guid id)
        {
            return await _creditDebitRepository.GetById(id);
        }
    }
}
