using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnISP
{
    public class Developer : IProjectDetails, IDeveloperTasks
    {
        public   void CompanyName(string CmpName)
        {
            Console.WriteLine("Company name:"+CmpName);
            
        }

        public void DevWork(string work)
        {
            Console.WriteLine("Work done by developer is:"+work);
        }

        public void ProjectId(int id)
        {
            Console.WriteLine("Project id:"+id);
        }

        public void ProjectName(string ProjName)
        {
            Console.WriteLine("Project Name:"+ProjName);
        }
        public void Display()
        {
            Developer res = new Developer();
            res.CompanyName("ABC");
            res.ProjectId(1);
            res.ProjectName("Bank");
            res.DevWork("Develops Code");
        }
    }
}
