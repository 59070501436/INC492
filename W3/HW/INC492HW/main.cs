using System;

namespace INC492HW
{
    class INC492HW
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter months: ");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime timenow = new DateTime(year, months, day);
            DateTime dayofyear = new DateTime(year, 12, 31);
            Console.WriteLine("Dayinput= {0:d}:", timenow);
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap Year!");
                
            }
            else
            {
                Console.WriteLine("Not a Leap Year!");
            }
            Console.WriteLine("How many day {0}", timenow.DayOfYear);
            Console.WriteLine("Ordered date = {0}:", dayofyear.DayOfYear);
           

        }
    }
}
