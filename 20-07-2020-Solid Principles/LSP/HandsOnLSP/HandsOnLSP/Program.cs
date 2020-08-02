using System;

namespace HandsOnLSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Dog();
            Console.WriteLine(animals.GetSound());
            animals = new Cat();
            Console.WriteLine(animals.GetSound());
            animals = new Snake();
            Console.WriteLine(animals.GetSound());
        }
    }
}
