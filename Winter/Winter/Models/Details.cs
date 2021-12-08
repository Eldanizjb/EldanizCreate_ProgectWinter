using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Details
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }

        [ForeignKey("Description")]
        public int DescriptionId { get; set; }
        public Description Description { get; set; }

        [ForeignKey("Cpecification")]
        public int CpecificationId { get; set; }
        public Cpecification Cpecification { get; set; }

        [ForeignKey("CommentAbout")]
        public int CommentsId { get; set; }
        public CommentAbout CommentAbout { get; set; }

        [ForeignKey("Reviews")]
        public int ReviewsId { get; set; }
        public Reviews Reviews { get; set; }


        public List<Product> Product { get; set; }


    }
}
