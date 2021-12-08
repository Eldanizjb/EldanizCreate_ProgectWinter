using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Cpecification
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Width { get; set; }
        [MaxLength(50)]
        public string Height { get; set; }
        [MaxLength(50)]
        public string Depth { get; set; }
        [MaxLength(50)]
        public string Weight { get; set; }
        [MaxLength(50)]
        public string checking { get; set; }
        [MaxLength(50)]
        public string Duration { get; set; }
        [MaxLength(50)]
        public string packeting { get; set; }
        [MaxLength(50)]
        public string contains { get; set; }
        public List<Details> Details { get; set; }

    }
}
