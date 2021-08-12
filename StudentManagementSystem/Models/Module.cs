using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Module
    {
        public string ModuleId { get; set; }
        public string Name { get; set; }

        public ICollection<StudentModules> StudentModules { get; set; }
    }
}
