using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Shipping
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Content { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
