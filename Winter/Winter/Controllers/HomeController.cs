using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Winter.Data;
using Winter.Models;
using Winter.ViewModels;

namespace Winter.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context )
        {
            _context = context;
        }

        public IActionResult Index()
        {

            VmHome model = new VmHome
            {

                Products = _context.Products.OrderByDescending(p => p.ProductCategory).Take(6).ToList(),

                ProductCategories = _context.ProductCategories.ToList(),
                Filters = _context.Filters.ToList(),
                Details = _context.Details.ToList(),
                BlogCategory = _context.BlogCategories.ToList()

            };
            return View(model);
        }
    }

}
