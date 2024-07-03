using Application.Requests;
using Domain.Interfaces;

namespace Application.UseCases.CreditDebits
{
    public interface IUpdateCreditDebitUseCase
    {
        Task Execute(UpdateCreditDebitRequest updateCreditDebitRequest);
    }
    public class UpdateCreditDebitUseCase(ICreditDebitRepository creditDebitRepository) : IUpdateCreditDebitUseCase
    {
        private readonly ICreditDebitRepository _creditDebitRepository = creditDebitRepository;
        public async Task Execute(UpdateCreditDebitRequest updateCreditDebitRequest)
        {
            var creditDebitToUpdate = await _creditDebitRepository.GetById(updateCreditDebitRequest.Id);
            creditDebitToUpdate.ModifiedAt = DateTime.UtcNow;
            creditDebitToUpdate.Value = updateCreditDebitRequest.Value;
            creditDebitToUpdate.IsCreditOrDebit = updateCreditDebitRequest.IsCreditOrDebit;
            creditDebitToUpdate.TransactionDate = updateCreditDebitRequest.TransactionDate;
            await _creditDebitRepository.Update(creditDebitToUpdate);
        }
    }
}
