using Microsoft.EntityFrameworkCore;
using ShopCET45.Web.Data.Entities;

namespace ShopCET45.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }


        public DbSet<Country> Countries { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
