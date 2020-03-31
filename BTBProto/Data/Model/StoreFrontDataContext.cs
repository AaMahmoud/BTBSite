using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace BTBProto.Data.Model
{
    public class StoreFrontDataContext : DbContext
    {
        public StoreFrontDataContext(DbContextOptions<StoreFrontDataContext> options)
            : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Customer> Customers { get; set; }
    }
}
