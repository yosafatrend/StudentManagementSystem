using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Address
    {
        public string AddressId { get; set; }
        [Required]
        public string StreetName { get; set; }
        public string Details { get; set; }
        [Required]
        //range kode pos indonesia
        [Range(10000, 99999)]
        public int PostalCode { get; set; }

        //kita tidak ingin map ini ke tabel
        [NotMapped]
        public string FullAddress
            => $"{StreetName} {Details}, Indonesia {PostalCode}";
        public string AdminNo { get; set; }
        public Student Student { get; set; }
    }
}
