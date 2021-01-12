using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExemploMVC_SalesWeb.Models;

namespace ExemploMVC_SalesWeb.Data
{
    public class ExemploMVC_SalesWebContext : DbContext
    {
        public ExemploMVC_SalesWebContext (DbContextOptions<ExemploMVC_SalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
