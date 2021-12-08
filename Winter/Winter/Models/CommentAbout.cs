using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class CommentAbout
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Pnone { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("ParentCommentAbout")]
        public int ParentCommentId { get; set; }
        public CommentAbout ParentCommentAbout { get; set; }
        public List<Details> Details { get; set; }

    }
}
