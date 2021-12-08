using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class AboutText
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Content { get; set; }
    }
}
