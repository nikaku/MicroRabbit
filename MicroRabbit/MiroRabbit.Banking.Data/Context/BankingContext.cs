using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MiroRabbit.Banking.Data.Context
{
    public class BankingContext : DbContext
    {
        public BankingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
