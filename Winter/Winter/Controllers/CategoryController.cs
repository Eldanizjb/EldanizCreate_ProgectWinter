using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Data;
using Winter.Models;

namespace Winter.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
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
