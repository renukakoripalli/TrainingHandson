using System;

namespace HandsOnDelegate
{
    public delegate void Caluculate(int width, int height);
    class Program
    {
        public static void AreaAndPerimeter(int width, int height)
        {
            Console.WriteLine("Area: {0}", width * height);
            Console.WriteLine("Perimeter: {0}", 2 * width + 2 * height);
        }
        static void Main()

        {
            Caluculate d = new Caluculate(AreaAndPerimeter);
            d(2, 3);
        }

    }

}
