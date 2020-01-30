using System;
namespace INC492
{
    public class Printdata
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int:{0}", i);

        }
        public void print(double f)
       {
           Console.WriteLine("Printing double:{0}", f);

      }
       public void print(string s)
       {
            Console.WriteLine("Printing string:{0}", s);
        }
    }
}
