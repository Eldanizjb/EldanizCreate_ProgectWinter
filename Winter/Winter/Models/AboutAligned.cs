using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Winter.Models
{
    public class AboutAligned
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(500)]
        public string Content{ get; set; }
    }
}
