using System;

namespace HandsOnISP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Developer dev = new Developer();
            //dev.Display();
            //Tester tester = new Tester();
            //tester.Display();
            char s;
            Console.WriteLine("A)Developer" + "B)Tester");

            Console.WriteLine("Enter role:");
            s = Convert.ToChar(Console.ReadLine());
          
            switch (Char.ToLower(s))
            {
                case 'a':
                    Developer dev = new Developer();
                    dev.Display();
                    Console.ReadLine();
                    break;
                case 'b':
                    Tester test = new Tester();
                    test.Display();
                    break;
                default:
                    Console.WriteLine("select correct option");
                    break;
            }
        }
    }
}
