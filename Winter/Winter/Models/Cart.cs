using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Product { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [MaxLength(50)]
        public string Quantity { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
           [MaxLength(50)]
        public string PostCode{ get; set; }

        [ForeignKey("Country")]
        public int Countryİd { get; set; }
        public Country Country { get; set; }


        [ForeignKey("Region")]
        public int Regionİd { get; set; }
        public Region Region { get; set; }


        public List<Order> Order { get; set; }


    }
}
