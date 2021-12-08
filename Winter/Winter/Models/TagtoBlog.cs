using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class TagtoBlog
    {
        [Key]
        public int Id { get; set; }
      
        
        [ForeignKey("Tag")]
        public int TagId{ get; set; }
        public Tag Tag { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
