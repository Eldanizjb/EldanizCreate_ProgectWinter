using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Select
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string box { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        public List<AboutSetting> AboutSetting { get; set; }

    }
}
