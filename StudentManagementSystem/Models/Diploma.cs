using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Diploma
    {
        public string DiplomaId { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
