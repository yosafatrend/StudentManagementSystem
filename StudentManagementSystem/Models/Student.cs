using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        //klo primary key nya ngga diakhiri "ID"
        [Key]
        public string AdminNo { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        //kita cuma pengen ngirim tanggalnya
        [DataType(DataType.Date)]
        //nama yg tampil
        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }

        //ketika kita cuma pengen datanya "M" atau "F"
        [Required]
        [StringLength(1)]
        public string Gender { get; set; }
        [Required]
        [RegularExpression(@"(\+62 ((\d{3}([ -]\d{3,})([- ]\d{4,})?)|(\d+)))|(\(\d+\) \d+)|\d{3}( \d+)+|(\d+[ -]\d+)|\d+",
            ErrorMessage = "Invalid Phone Number!")]
        [Display(Name = "Handphone")]
        public string ContactNumber { get; set; }

        public Address Address { get; set; }

        [Required]
        [Display(Name = "Diploma")]
        public string DiplomaId { get; set; }
        public Diploma Diploma { get; set; }

        public ICollection<StudentModules> StudentModules { get; set; }
    }
}
