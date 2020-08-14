using Microsoft.EntityFrameworkCore;
using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Infra.Mappings;
using System.Configuration;

namespace SaveMyMoney.Infra.Contexts
{
    public class SaveMyMoneyDataContext : DbContext
    {
        //here so i can use migration
        public SaveMyMoneyDataContext() { }
        public SaveMyMoneyDataContext(DbContextOptions<SaveMyMoneyDataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=SaveMyMoney;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
