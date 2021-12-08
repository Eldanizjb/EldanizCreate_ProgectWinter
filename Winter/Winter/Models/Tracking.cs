using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Tracking
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Coupon { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Address1 { get; set; }
        [MaxLength(100)]
        public string Address2 { get; set; }
        [MaxLength(100)]
        public string Town { get; set; }
        [MaxLength(100)]
        public string PostCode { get; set; }
        [MaxLength(50)]
        public string Notes { get; set; }


        [ForeignKey("Country")]

        public int CountryId { get; set; }
        public Country Country { get; set; }


        [ForeignKey("District")]

        public int DistrictId { get; set; }
        public District District { get; set; }

    }
}
