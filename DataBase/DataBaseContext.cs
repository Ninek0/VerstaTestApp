using Microsoft.EntityFrameworkCore;
using VerstaTestApp.Models;
namespace VerstaTestApp.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<OrderModel> Orders { get; set; }
    }
}
