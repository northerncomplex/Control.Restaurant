using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using warehouse.DAL.Entities;

namespace warehouse.DAL
{
    class StockDbContext : DbContext
    {
        public DbSet<Procurement> Procurements { get; set; }
        public DbSet<ProductType> Classes { get; set; }
        public DbSet<Stock> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        static StockDbContext() {
            Database.SetInitializer<StockDbContext>(new StoreDbInitializer());
        }
        public StockDbContext(string connStr)
            : base(connStr)
        { }

        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<StockDbContext> {
            protected override void Seed(StockDbContext db)
            {

            }
        }
    }
}
