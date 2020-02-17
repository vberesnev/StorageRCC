using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Model
{
    class StorageContext : DbContext
    {
        public StorageContext() : base("StorageConnection") { }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
