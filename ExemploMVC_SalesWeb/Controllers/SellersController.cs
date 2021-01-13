using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploMVC_SalesWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExemploMVC_SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
