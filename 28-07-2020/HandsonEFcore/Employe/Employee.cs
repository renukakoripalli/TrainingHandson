using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employe
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Mobileno { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public Project Project { get; set; }
    }
}
