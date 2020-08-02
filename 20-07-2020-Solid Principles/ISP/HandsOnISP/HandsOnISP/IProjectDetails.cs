using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnISP
{
    public  interface IProjectDetails
    {
         void CompanyName(string CmpName);
        void ProjectId(int id);
        void ProjectName(string ProjName);
    }
    interface IDeveloperTasks
    {
        void DevWork(string work);
    }
    interface ITesterTasks
    {
        void TesterWork(string work);
    }
}
