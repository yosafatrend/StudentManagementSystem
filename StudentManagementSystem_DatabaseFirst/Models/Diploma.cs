using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem_DatabaseFirst.Models
{
    public partial class Diploma
    {
        public Diploma()
        {
            Students = new HashSet<Student>();
        }

        public string DiplomaId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
