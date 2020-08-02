using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Repositories
{
    public interface IEmployeeRepository
    {
        void AddEmp(Employees obj);
        
        void DeleteEmp(int EmpId);
        void EditProfile(Employees obj);
        Employees GetById(int EmpId);
        List<Employees> GetAll();
    }
}
