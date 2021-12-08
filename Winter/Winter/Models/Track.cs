using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Order { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Content { get; set; }
    }
}
