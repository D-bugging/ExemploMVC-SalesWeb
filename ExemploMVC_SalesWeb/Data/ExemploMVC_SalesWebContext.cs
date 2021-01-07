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

        public DbSet<ExemploMVC_SalesWeb.Models.Department> Department { get; set; }
    }
}
