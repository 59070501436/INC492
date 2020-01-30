using System;
namespace INC492
{
    public class Car
    {
        private string color;

        public string Describe()
        {
            return "This car is" + Color;
        }

        public string Color
        {
            get { return color.ToUpper(); }
            set { color = value; }
        }

        public Car()
        {
            Console.WriteLine("Constructor with no parameterscalled!");
        }

        public Car(string color)
        {
            this.color = color;
            Console.WriteLine("Constructor with color parametercalled!");
        }

    }
}
