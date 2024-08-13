using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {}
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
              

    }
}
