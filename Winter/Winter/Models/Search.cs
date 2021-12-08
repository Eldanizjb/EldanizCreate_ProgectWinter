using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Search
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Blog> Blog { get; set; }

    }
}
