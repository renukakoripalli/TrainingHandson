using System;
using System.Collections.Generic;
using System.Linq;


namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>
            {
                new Employee{EmpId=1,EmpName="renu",Salary=30000,Gender='F',Experience=2},
                new Employee{EmpId=2,EmpName="siva",Salary=45000,Gender='M',Experience=5},
                new Employee{EmpId=3,EmpName="rani",Salary=42000,Gender='F',Experience=3},
                new Employee{EmpId=4,EmpName="pravallika",Salary=25000,Gender='F',Experience=1},
                new Employee{EmpId=5,EmpName="Revanth",Salary=30000,Gender='M',Experience=2},
             };
            //Select=is used when you want to select  value from the given list.
            var res0 = EmployeeList.Select(a => a.EmpName ).ToList();
            foreach (var val0 in res0)          
            Console.WriteLine(val0);
            //Where=returns the values from the list based on the given condition 
            List<Employee> employeename = EmployeeList.Where(x => x.Gender == 'M').ToList();
            foreach(var item in employeename)
            Console.WriteLine(item.EmpName);
            //OrderBy = returns rearranging the elements of the given list in ascending order
            var res2 = EmployeeList.OrderBy(a => a.Salary);          
            foreach (var x in res2)
            Console.WriteLine(x.Salary);
            //OrderByDescending=returns rearranging the elements of the given list in descending order
            var res3 = EmployeeList.OrderByDescending(a => a.Salary);
            foreach (var y in res3)
            Console.WriteLine(y.Salary);
            //ThenBy=return the list with given slaray in ascending order
            var res4 = EmployeeList.OrderBy(e => e.EmpName).ThenBy(e => e.Salary);
            foreach (var z in res4)           
            Console.WriteLine("Employee Name: {0} Salary: {1}",z.EmpName,z.Salary);
            //reverse= it reverses the order of the collection, i.e in descending order.
            var res5 = EmployeeList.OrderBy(e => e.EmpName).Reverse();
            foreach (var v in res5)           
            Console.WriteLine(v.EmpName);
            //GroupBy=returns the group of elements based on the given key
            var res6 = EmployeeList.GroupBy(e => e.Gender);
            foreach (var r in res6)
            {
                Console.WriteLine(r.Key);
                foreach (Employee e in r)
                    Console.WriteLine(e.EmpName);
            }
            //Sum=adds the list values
            var res7 = EmployeeList.Sum(e => e.Salary);
            Console.WriteLine(res7);
            //Average=returns the average of the values in the list
            var res8 = EmployeeList.Average(e => e.Salary);
            Console.WriteLine(res8);
            //Min=returns minimum value from the list
            var res9 = EmployeeList.Min(e => e.Salary);
            Console.WriteLine(res9);
            /*All=All operator is used to check each and every element in the list if all the elements satisfy 
              the given condition then it will return true.Otherwise, return false*/
            var res10 = EmployeeList.All(e => e.Gender =='F');
            Console.WriteLine(res10);
            //Single operator=to return the single element from the list or returns the single element which specifies the given condition.
            var res = EmployeeList.Single(e => e.EmpName == "renu");
            int val = res.Salary;
            Console.WriteLine(val);
            /*SingleOrDefault= returns the only element of the collection or sequence which specifies the given condition 
            and will throw an exception if more than one element exists that specifies the given condition*/
            var res1 = EmployeeList.SingleOrDefault(e => e.Salary ==25000);
            string val1 = res1.EmpName;
            Console.WriteLine(val1);
            //=>
            List<int> List1 = new List<int>() { 3,6,2,7,9 };
            List<int> List2 = new List<int>() { 1,4,6,5,9 };
            //Union=returns the lists combine
            var resUnion = List1.Union(List2);
            foreach (var v in resUnion)
            Console.WriteLine(v);
            //Except=returns the set difference
            var resExcept = List1.Except(List2);
            foreach (var j in resExcept)
            Console.WriteLine(j);
            //Intersect=return the set  which contain the common elements appears in two sets.
            var resIntersect = List1.Intersect(List2);
            foreach (var v in resIntersect)
            Console.WriteLine(v);
            //Distinct=returns the set which does not contain duplicate values
            List<char> List3 = new List<char>() { 'w', 'r', 'v', 'a', 'a', 'r', 'y', 'w' };
            var result = List3.Distinct();
            foreach (var v in result)
             Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
