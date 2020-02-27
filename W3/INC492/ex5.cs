using System;
namespace INC492
{
    public class Animal
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hello, I'm some sort of animal!");
        }
    }
     public class Dog : Animal
    {
        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("Hello, I'm a dog!");
        }

    }
}
