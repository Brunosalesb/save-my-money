using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaveMyMoney.Domain.Entities;

namespace SaveMyMoney.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.OwnsOne(x => x.Name).Property(x=>x.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(32);
            builder.OwnsOne(x => x.Name).Property(x => x.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(32);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(32);
            builder.Property(x => x.SignUpDate).IsRequired();
        }
    }
}
