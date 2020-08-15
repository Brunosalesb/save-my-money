using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaveMyMoney.Domain.Entities;

namespace SaveMyMoney.Infra.Mappings
{
    public class TransferMap : IEntityTypeConfiguration<Transfer>
    {
        public void Configure(EntityTypeBuilder<Transfer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Value).HasColumnType("Money").IsRequired();
            builder.Property(x => x.TransferDate);
            builder.Property(x => x.RegisterDate).IsRequired();
            builder.Property(x => x.TransferType).IsRequired();

            builder.HasOne(x => x.User).WithMany(y => y.Transfer).HasForeignKey(z => z.UserId);
        }
    }
}
