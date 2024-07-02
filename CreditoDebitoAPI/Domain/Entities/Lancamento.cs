using Domain.Enumerators;

namespace Domain.Entities
{
    public class Lancamento : Base
    {
        public decimal Value { get; set; }
        public DateTime? TransactionDate { get; set; } = DateTime.Now;
        public CreditDebitType CreditOrDebit { get; set; }
    }
}
