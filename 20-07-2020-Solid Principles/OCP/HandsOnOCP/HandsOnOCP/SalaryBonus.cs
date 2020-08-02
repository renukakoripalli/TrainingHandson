using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnOCP
{
    public class SalaryBonus
    {
        public virtual double GetSalaryBonus(double amount)
        {
            return amount ;
        }
    }

    public class ManagerBonus : SalaryBonus
    {
        public override double GetSalaryBonus(double amount)
        {
            return base.GetSalaryBonus(amount) + 4000;
        }
    }
    public class DeveloperBonus : SalaryBonus
    {
        public override double GetSalaryBonus(double amount)
        {
            return base.GetSalaryBonus(amount) + 3000;
        }
    }
    public class TesterBonus : SalaryBonus
    {
        public override double GetSalaryBonus(double amount)
        {
            return base.GetSalaryBonus(amount) + 2000;
        }
    }
}
