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
            List<Product> products = _context.Products.Include("ProductCategory").Include("Filter").Include("Details").ToList();

            return View(products);
        }

  
    }
}
