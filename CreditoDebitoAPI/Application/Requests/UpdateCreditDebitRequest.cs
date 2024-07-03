using Domain.Enumerators;

namespace Application.Requests
{
    public class UpdateCreditDebitRequest(Guid id, decimal value, DateTime transactionDate, CreditDebitType isCreditOrDebit)
    {
        public Guid Id { get; set; } = id;
        public decimal Value { get; set; } = value;
        public DateTime TransactionDate { get; set; } = transactionDate;
        public CreditDebitType IsCreditOrDebit { get; set; } = isCreditOrDebit;
    }
}
