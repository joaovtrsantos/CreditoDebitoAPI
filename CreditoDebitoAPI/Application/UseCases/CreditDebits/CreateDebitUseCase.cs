using Application.Requests;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.CreditDebits
{
    public interface ICreateCreditDebitUseCase
    {
        Task Execute(CreateCreditDebitRequest productRequest);
    }

    public class CreateCreditDebitUseCase(ICreditDebitRepository creditDebitRepository) : ICreateCreditDebitUseCase
    {
        private readonly ICreditDebitRepository _creditDebitRepository = creditDebitRepository;

        public async Task Execute(CreateCreditDebitRequest productRequest)
        {
            var creditDebitEntity = new CreditDebit()
            {
                IsCreditOrDebit = productRequest.IsCreditOrDebit,
                TransactionDate = productRequest.TransactionDate,
                Value = productRequest.Value,
            };

            await _creditDebitRepository.Add(creditDebitEntity);
        }
    }
}
