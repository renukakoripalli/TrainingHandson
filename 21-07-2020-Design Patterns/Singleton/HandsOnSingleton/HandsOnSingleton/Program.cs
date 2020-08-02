using System;

namespace HandsOnSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton a=Singleton.GetInstance;
            //a.Area(2,3);
            //Console.WriteLine(a);
            //Singleton b = Singleton.GetInstance;
            //b.Perimeter(2, 3);
            //Console.WriteLine(b);
           Console.WriteLine("Area of rectangle : " + Singleton.GetInstance.Area(2,2));
           Console.WriteLine("Perimeter of rectangle : " + Singleton.GetInstance.Perimeter(3, 2));
           Console.ReadLine();
        }
    }
}
