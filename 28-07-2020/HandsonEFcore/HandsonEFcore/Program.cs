using Employe;
using System;
using EmployeeDB;

namespace HandsonEFcore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(CompanyDbContext db = new CompanyDbContext())
            {
                //insert new record
                Project project = new Project() {  ProjectName = "MRM" };
                db.Projects.Add(project);
                db.SaveChanges();
                Employee employee = new Employee() { EmpName = "renu", Mobileno = "9045036050", Experience=1,   Salary = 30000, Project = project };
                db.Employees.Add(employee);
                db.SaveChanges();
                //fetch record
                Employee employee1 = db.Employees.Find(employee.EmpId);
                Console.WriteLine("Welcome {0}", employee1.EmpName);
                Console.WriteLine(employee1.Mobileno);
                Console.WriteLine(employee1.Salary);
            }
        }
    }
}
