﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploMVC_SalesWeb.Data;
using ExemploMVC_SalesWeb.Models;

namespace ExemploMVC_SalesWeb.Services
{
    public class SellerService
    {
        private readonly ExemploMVC_SalesWebContext _context;

        public SellerService(ExemploMVC_SalesWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
