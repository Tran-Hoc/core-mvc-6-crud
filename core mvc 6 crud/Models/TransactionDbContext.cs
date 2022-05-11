using Microsoft.EntityFrameworkCore;

namespace core_mvc_6_crud.Models
{
    public class TransactionDbContext: DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
