using System;

namespace INC492
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            ///Ex2
           // rectangle.Accptdetails();
            ////Ex1
            //rectangle.Display();
            Console.WriteLine("Hello World!");
            ///print funtion type all
            ///
            ///ex3
            //Printdata printex3 = new Printdata();
            // printex3.print(5);
            //printex3.print(500.263);
            // printex3.print("Hello c# world");
            // Console.ReadKey();
            Car car;
            car = new Car("Red");
            Console.WriteLine(car.Describe());
            car = new Car("Green");
            Console.WriteLine(car.Describe());


            

        }
    }
}
