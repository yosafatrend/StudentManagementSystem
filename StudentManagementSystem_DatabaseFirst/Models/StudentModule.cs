using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem_DatabaseFirst.Models
{
    public partial class StudentModule
    {
        public string AdminNo { get; set; }
        public string ModuleId { get; set; }

        public virtual Student AdminNoNavigation { get; set; }
        public virtual Module Module { get; set; }
    }
}
