using Microsoft.EntityFrameworkCore;
using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Infra.Mappings;
using System.Configuration;

namespace SaveMyMoney.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TransferMap());
        }
    }
}
