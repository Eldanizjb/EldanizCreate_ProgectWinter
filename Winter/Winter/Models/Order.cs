using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Subtotal { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Shipping { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(50)]
        public string CheckPay { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }



    }
}
