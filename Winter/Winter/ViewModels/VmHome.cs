using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Models;

namespace Winter.ViewModels
{
    public class VmHome : VmLayout
    {
        internal object BlogCategory;

        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<Filter> Filters { get; set; }

        public List<Details> Details { get; set; }
    }
}
