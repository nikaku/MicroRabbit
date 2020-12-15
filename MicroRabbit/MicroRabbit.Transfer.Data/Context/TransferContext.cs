using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferContext : DbContext
    {
        public TransferContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TransferLog> TransferLogs;
    }
}
