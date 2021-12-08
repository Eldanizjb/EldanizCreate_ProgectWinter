using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(50)]
        public DateTime CreatedDate { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Content { get; set; }


        [ForeignKey("BlogCategory")]
        public int Categoryİd { get; set; }
        public BlogCategory BlogCategory { get; set; }


        [ForeignKey("User")]
        public int Userİd { get; set; }
        public User User { get; set; }

        [ForeignKey("Posts")]
        public int PostId { get; set; }
        public Posts Posts { get; set; }

        [ForeignKey("Search")]
        public int SearchId { get; set; }
        public Search Search { get; set; }

        public List<TagtoBlog> TagtoBlog { get; set; }

        public List<Comment> Comment { get; set; }



    }
}
