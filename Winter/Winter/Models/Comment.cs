using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        public string Text{ get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(250)]
        public string Website { get; set; }

        [ForeignKey("ParentComment")]
        public int ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
