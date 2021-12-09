using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter.Models;

namespace Winter.ViewModels
{
    public class VmLayout
    {
        public List<Setting> Settings { get; set; }
        public List<Shipping> Shipping { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }


    }
}
