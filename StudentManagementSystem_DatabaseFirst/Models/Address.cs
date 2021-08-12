using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem_DatabaseFirst.Models
{
    public partial class Address
    {
        public string AddressId { get; set; }
        public string StreetName { get; set; }
        public string Details { get; set; }
        public int PostalCode { get; set; }
        public string AdminNo { get; set; }

        public virtual Student Student { get; set; }
    }
}
