using System;

namespace HandsOnOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryBonus m = new ManagerBonus();
            SalaryBonus d = new DeveloperBonus();
            SalaryBonus t = new TesterBonus();
            double ManagerSalary = m.GetSalaryBonus(45000);
            Console.WriteLine("Manager salary:"+ManagerSalary);
            double DeveloperSalary = d.GetSalaryBonus(30000);
            Console.WriteLine("Developer salary:"+DeveloperSalary);
            double TesterSalary = t.GetSalaryBonus(20000);
            Console.WriteLine("Tester salary:"+TesterSalary);
            Console.ReadLine();
        }
    }
}
