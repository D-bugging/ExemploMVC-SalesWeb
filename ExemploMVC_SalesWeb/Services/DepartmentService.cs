using ExemploMVC_SalesWeb.Data;
using ExemploMVC_SalesWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExemploMVC_SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly ExemploMVC_SalesWebContext _context;

        public DepartmentService(ExemploMVC_SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
