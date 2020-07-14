using System;
using System.Collections.Generic;
using System.Linq;


namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeelist = new List<Employee>
            {
                new Employee{empid=1,empname="renu",salary=30000,gender='F',experience=2},
                new Employee{empid=2,empname="siva",salary=45000,gender='M',experience=5},
                new Employee{empid=3,empname="rani",salary=42000,gender='F',experience=3},
                new Employee{empid=4,empname="pravallika",salary=25000,gender='F',experience=1},
                new Employee{empid=5,empname="Revanth",salary=30000,gender='M',experience=2},
             };
            //Where=returns the values from the list based on the given condition 
            List<Employee> employeename = employeelist.Where(x => x.gender == 'M').ToList();
            foreach(var item in employeename)
            Console.WriteLine(item.empname);
            //Single operator=to return the single element from the list or returns the single element which specifies the given condition.
            var res = employeelist.Single(e => e.empname == "renu");
            int val = res.salary;
            Console.WriteLine(val);
            /*SingleOrDefault= returns the only element of the collection or sequence which specifies the given condition 
            and will throw an exception if more than one element exists that specifies the given condition*/
            var res1 = employeelist.SingleOrDefault(e => e.salary == 60000);
            string val1 = res1.empname;
            Console.WriteLine(val1);
            //OrderBy = returns rearranging the elements of the given list in ascending order
            var res2 = employeelist.OrderBy(a => a.salary);          
            foreach (var x in res2)
            Console.WriteLine(x.salary);
            //OrderByDescending=returns rearranging the elements of the given list in descending order
            var res3 = employeelist.OrderByDescending(a => a.salary);
            foreach (var y in res3)
            Console.WriteLine(y.salary);
            //ThenBy=
            var res4 = employeelist.OrderBy(e => e.empname).ThenBy(e => e.salary);
            foreach (var z in res4)           
            Console.WriteLine("Employee Name: {0} Salary: {1}",z.empname,z.salary);
            //reverse= it reverses the order of the collection, i.e in descending order.
            var res5 = employeelist.OrderBy(e => e.empname).Reverse();
            foreach (var v in res5)           
            Console.WriteLine(v.empname);
            //GroupBy=returns the group of elements based on the given key
            var res6 = employeelist.GroupBy(e => e.gender);
            foreach (var r in res6)
            {
                Console.WriteLine(r.Key);
                foreach (Employee e in r)
                    Console.WriteLine(e.empname);
            }
            //Sum=adds the list values
            var res7 = employeelist.Sum(e => e.salary);
            Console.WriteLine(res7);
            //Average=returns the average of the values in the list
            var res8 = employeelist.Average(e => e.salary);
            Console.WriteLine(res8);
            //Min=returns minimum value from the list
            var res9 = employeelist.Min(e => e.salary);
            Console.WriteLine(res9);
            /*All=All operator is used to check each and every element in the list if all the elements satisfy 
              the given condition then it will return true.Otherwise, return false*/
            var res10 = employeelist.All(e => e.gender =='F');
            Console.WriteLine(res10);

        Console.ReadLine();
        }
    }
}
