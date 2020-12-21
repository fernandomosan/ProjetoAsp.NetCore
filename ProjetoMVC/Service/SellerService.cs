using ProjetoMVC.Data;
using ProjetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Service
{
    public class SellerService
    {
        private readonly ProjetoMVCContext _context;

        public SellerService(ProjetoMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
