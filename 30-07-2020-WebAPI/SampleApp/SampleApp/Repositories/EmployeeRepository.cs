using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanyDBContext _context;
        public EmployeeRepository(CompanyDBContext context)
        {
            _context = context;
        }
        public void AddEmp(Employees obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEmp(int EmpId)
        {
            Employees emp = _context.Employees.Find(EmpId);
            _context.Remove(emp);
            _context.SaveChanges();
        }

        public void EditProfile(Employees obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }

        public List<Employees> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employees GetById(int EmpId)
        {
            return _context.Employees.Find(EmpId);
        }
    }
}
