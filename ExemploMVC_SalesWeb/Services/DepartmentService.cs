using ExemploMVC_SalesWeb.Data;
using ExemploMVC_SalesWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExemploMVC_SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly ExemploMVC_SalesWebContext _context;

        public DepartmentService(ExemploMVC_SalesWebContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
