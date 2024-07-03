using Application.Requests;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.CreditDebits
{
    public interface IDeleteCreditDebitUseCase
    {
        Task Execute(Guid Id);
    }
    public class DeleteCreditDebitByIdUseCase(ICreditDebitRepository creditDebitRepository) : IDeleteCreditDebitUseCase
    {
        private readonly ICreditDebitRepository _creditDebitRepository = creditDebitRepository;
        public async Task Execute(Guid id)
        {
            await _creditDebitRepository.Delete(id);
        }
    }
}
