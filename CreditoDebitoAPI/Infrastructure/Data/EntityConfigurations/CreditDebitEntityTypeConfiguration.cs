using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntityConfigurations
{
    public class CreditDebitEntityTypeConfiguration : IEntityTypeConfiguration<CreditDebit>
    {
        public void Configure(EntityTypeBuilder<CreditDebit> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IsCreditOrDebit)
                .IsRequired(true);

            builder.Property(x => x.TransactionDate)
                 .IsRequired(true);

            builder.Property(x => x.ModifiedAt)
                .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                .IsRequired(true);

            builder.Property(x => x.Value)
                 .IsRequired(true);
        }
    }
}
