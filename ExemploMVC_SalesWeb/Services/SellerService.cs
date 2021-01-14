﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploMVC_SalesWeb.Data;
using ExemploMVC_SalesWeb.Models;
using Microsoft.EntityFrameworkCore;

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

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
