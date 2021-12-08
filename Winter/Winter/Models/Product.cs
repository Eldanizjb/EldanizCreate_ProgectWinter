using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(20)]
        public string Icon1 { get; set; }
        [MaxLength(20)]
        public string Icon2 { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [MaxLength(50)]
        public string Category { get; set; }
        [MaxLength(50)]
        public string Availibility { get; set; }
        [MaxLength(50)]
        public string Sosial { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public ProductCategory ProductCategory { get; set; }


        [ForeignKey("Filter")]
        public int FilterId { get; set; }
        public Filter Filter { get; set; }


        [ForeignKey("Details")]
        public int AboutId { get; set; }
        public Details Details { get; set; }



    }
}
