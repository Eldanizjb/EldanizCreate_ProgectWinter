using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Filter
    {
        [Key]
        public int Id { get; set; }
        

        public int PercentStart { get; set; }
        
        public int PercentEnd { get; set; }
        public List<Product> Product { get; set; }

    }
}
