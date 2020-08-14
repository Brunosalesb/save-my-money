using Microsoft.EntityFrameworkCore;
using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Infra.Mappings;

namespace SaveMyMoney.Infra.Contexts
{
    public class SaveMyMoneyDataContext : DbContext
    {
        public SaveMyMoneyDataContext(DbContextOptions<SaveMyMoneyDataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
