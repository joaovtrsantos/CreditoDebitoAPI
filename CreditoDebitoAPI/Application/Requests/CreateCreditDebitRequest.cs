using Domain.Enumerators;

namespace Application.Requests
{
    public class CreateCreditDebitRequest(decimal value, DateTime transactionDate, CreditDebitType isCreditOrDebit)
    {
        public decimal Value { get; set; } = value;
        public DateTime TransactionDate { get; set; } = transactionDate;
        public CreditDebitType IsCreditOrDebit { get; set; } = isCreditOrDebit;
    }
}
