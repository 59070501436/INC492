using System;

namespace INC492
{
    class Rectangle
    {
        public double length;
        public double width;

        public double GetAree()
        {
            return length * width;

        }

        public void Display()
        {
            Console.WriteLine("length:{0}", length);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Aree:{0}", GetAree());
        }
    }
}
