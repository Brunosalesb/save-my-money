using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaveMyMoney.Domain.Entities;

namespace SaveMyMoney.Infra.Mappings
{
    public class WalletMap : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Balance).HasColumnType("Money").IsRequired();

            builder.HasOne(x => x.User).WithOne(y => y.Wallet).HasForeignKey<Wallet>(z => z.UserId);
        }
    }
}
