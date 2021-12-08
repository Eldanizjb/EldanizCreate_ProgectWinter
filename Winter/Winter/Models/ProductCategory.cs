using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
     
        [ForeignKey("SideCategory")]
        public int SlideId { get; set; }
        public SideCategory SideCategory { get; set; }


        public List<Product> Product { get; set; }

    }
}
