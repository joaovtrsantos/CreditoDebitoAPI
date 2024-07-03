using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enumerators;

namespace Domain.Entities
{
    public class CreditDebit : Base
    {
        private decimal _value;

        [Column(TypeName = "decimal(18,8)")]
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

        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public CreditDebitType IsCreditOrDebit { get; set; }
    }
}
