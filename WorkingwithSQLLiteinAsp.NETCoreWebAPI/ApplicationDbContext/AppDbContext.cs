using Microsoft.EntityFrameworkCore;
//using WorkingwithSQLLiteinAsp.NETCoreWebAPI.Models;

namespace WorkingwithSQLLiteinAsp.NETCoreWebAPI.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Investor> Investors { get; set; }
         public DbSet<Commitment> Commitments { get; set; }
   
    }
}