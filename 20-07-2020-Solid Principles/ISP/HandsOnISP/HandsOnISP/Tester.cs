using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnISP
{
    public class Tester : IProjectDetails, ITesterTasks
    {
        public void CompanyName(string CmpName)
        {
            Console.WriteLine("Company Name:"+CmpName);
        }

        public void ProjectId(int id)
        {
            Console.WriteLine("Project id:" + id);
        }

        public void ProjectName(string ProjName)
        {
            Console.WriteLine("Project Name:" + ProjName);
        }

        public void TesterWork(string work)
        {
            Console.WriteLine("Work done by tester is:" + work);
        }
        public void Display()
        {
            Tester res1 = new Tester();
            res1.CompanyName("ABC");
            res1.ProjectId(1);
            res1.ProjectName("Bank");
            res1.TesterWork("Tests Code");
        }
    }
}
