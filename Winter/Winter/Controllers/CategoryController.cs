using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Data;
using Winter.Models;
using Winter.ViewModels;

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

            VmHome model = new VmHome
            {

                Products = _context.Products.OrderByDescending(p => p.ProductCategory).Take(6).ToList(),

                ProductCategories = _context.ProductCategories.ToList(),
                Filters = _context.Filters.ToList(),
                Details = _context.Details.ToList()
            };
            return View(model);
        }
    }
}
