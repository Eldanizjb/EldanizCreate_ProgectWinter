using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winter.Models
{
    public class Reviews
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Width { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }

        public List<Details> Details { get; set; }



    }
}
