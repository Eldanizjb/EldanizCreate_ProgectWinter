using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Box { get; set; }
        public List<Tracking> Tracking { get; set; }

    }
}
