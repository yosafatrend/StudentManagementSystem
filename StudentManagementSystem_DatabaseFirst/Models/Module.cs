using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem_DatabaseFirst.Models
{
    public partial class Module
    {
        public Module()
        {
            StudentModules = new HashSet<StudentModule>();
        }

        public string ModuleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentModule> StudentModules { get; set; }
    }
}
