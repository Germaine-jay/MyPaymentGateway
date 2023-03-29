using Microsoft.EntityFrameworkCore;
using PaymentGateway.Models.Entities;

namespace PaymentGateway.DAL.Database
{

    public class PaymentGatewayDbContext : DbContext
    {
        public PaymentGatewayDbContext(DbContextOptions<PaymentGatewayDbContext> options)
        : base(options)
        {

        }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e =>
            {
                e.Property(p => p.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                e.Property(p => p.LastName)
                   .IsRequired(false)
                   .HasMaxLength(30);

                e.HasIndex(p => new { p.Email, p.PhoneNumber }, $"IX_Unique_{nameof(User.Email)}{nameof(User.PhoneNumber)}")
                   .IsUnique();

                e.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(12);

            });

            modelBuilder.Entity<Wallet>()
                .HasKey(a => a.WalletId);

            modelBuilder.Entity<Wallet>(p =>
            {
                p.Property(p => p.WalletId)
                    .ValueGeneratedOnAdd();

                p.Property(p => p.Balance)
                    .HasDefaultValue(0);

            });

            modelBuilder.Entity<User>()
                .HasMany(t1 => t1.Wallet)
                .WithOne(t2 => t2.User)
                .HasForeignKey(t2 => t2.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

        }
    }
}
