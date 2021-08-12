using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem_DatabaseFirst.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentModules = new HashSet<StudentModule>();
        }

        public string AdminNo { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string DiplomaId { get; set; }

        public virtual Address AdminNoNavigation { get; set; }
        public virtual Diploma Diploma { get; set; }
        public virtual ICollection<StudentModule> StudentModules { get; set; }
    }
}
