using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage
{
    public class  Context : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Role> Role { get; set; }

        public Context()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RSCG4O2;Database=FinanceManager;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .HasOne(p => p.Wallet)
                .WithMany(t => t.Transactions)
                .HasForeignKey(p => p.WalletId);

            modelBuilder.Entity<Wallet>()
                .HasOne(p => p.User)
                .WithMany(t => t.Wallets)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<User>()
                .HasOne(p => p.Role)
                .WithMany(t => t.Users)
                .HasForeignKey(p => p.RoleId);
        }
    }
}
