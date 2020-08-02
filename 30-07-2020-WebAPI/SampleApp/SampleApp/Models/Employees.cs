using System;
using System.Collections.Generic;

namespace SampleApp.Models
{
    public partial class Employees
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Mobileno { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public int? ProjectId { get; set; }

        public virtual Projects Project { get; set; }
    }
}
