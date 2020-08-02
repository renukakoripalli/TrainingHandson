using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnSingleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        //public double width { get; set; }
        //public double height { get; set; }
        public double Area(double width,double height)
        {
            return width*height;
        }
        public double Perimeter(double width,double height)
        {
            return 2*width+2*height;
        }
        
    }
}

