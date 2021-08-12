using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class StudentModules
    {
        public string AdminNo { get; set; }
        public Student Student { get; set; }
        public string ModuleId { get; set; }
        public Module Module { get; set; }
    }
}
