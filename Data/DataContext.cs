using Microsoft.EntityFrameworkCore;
using Entites;
namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<userData> User {get;set;}
    }
}