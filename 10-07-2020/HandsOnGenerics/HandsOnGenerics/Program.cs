using System;

namespace HandsOnGenerics
{
    //Generic Class Example
    public class Generics<T>
    {
        public T msg;
        public void Caluculation(int width, int height)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Area: {0}", (width * height));
            Console.WriteLine("Perimeter: {0}", 2 * width + 2 * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {          
            Generics<string> gen = new Generics<string>();
            gen.msg = "Welcome!!!";
            gen.Caluculation(2,3);
            Console.ReadLine();
        }
    }
}

