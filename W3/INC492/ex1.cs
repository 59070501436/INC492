using System;

namespace INC492
{
    class Rectangle
    {
        public double length;
        public double width;

        public void Accptdetails()
        {
            Console.WriteLine("Enter Length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width");
            width = Convert.ToDouble(Console.ReadLine());


        }
        
        
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
