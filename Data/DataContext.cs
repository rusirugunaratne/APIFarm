using APIFarm.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFarm.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base( options )
        {

        }

        //tables
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
