using Application.Requests;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.CreditDebits
{
    public interface ICreateCreditDebitUseCase
    {
        Task Execute(CreateCreditDebitRequest createDebitRequest);
    }

    public class CreateCreditDebitUseCase(ICreditDebitRepository creditDebitRepository) : ICreateCreditDebitUseCase
    {
        private readonly ICreditDebitRepository _creditDebitRepository = creditDebitRepository;

        public async Task Execute(CreateCreditDebitRequest createDebitRequest)
        {
            var creditDebitEntity = new CreditDebit()
            {
                IsCreditOrDebit = createDebitRequest.IsCreditOrDebit,
                TransactionDate = createDebitRequest.TransactionDate,
                Value = createDebitRequest.Value,
            };

            await _creditDebitRepository.Add(creditDebitEntity);
        }
    }
}
