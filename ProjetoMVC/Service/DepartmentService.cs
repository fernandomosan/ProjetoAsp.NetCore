using ProjetoMVC.Data;
using ProjetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Service
{
    public class DepartmentService
    {
        private readonly ProjetoMVCContext _context;

        public DepartmentService(ProjetoMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
