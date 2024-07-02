using System;
using Domain.Enumerators;

namespace Domain.Entities
{
    public class CreditDebit : Base
    {
        private decimal _value;

        public decimal Value
        {
            get => _value;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be less or equal than 0.");
                }
                _value = value;
            }
        }

        public DateTime? TransactionDate { get; set; } = DateTime.Now;
        public CreditDebitType IsCreditOrDebit { get; set; }
    }
}
