using System;
using System.Collections.Generic;

namespace SampleApp.Models
{
    public partial class Projects
    {
        public Projects()
        {
            Employees = new HashSet<Employees>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
