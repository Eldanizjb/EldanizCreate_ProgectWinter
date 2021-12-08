using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Accound
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name{ get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
           }
}
