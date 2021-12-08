using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string IsAdmin { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        public DateTime CreatedData { get; set; }
        public List<Blog> Blog { get; set; }

    }
}
