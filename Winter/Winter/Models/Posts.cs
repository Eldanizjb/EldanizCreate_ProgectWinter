using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Blog> Blog { get; set; }

    }
}
