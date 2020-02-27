using System;

namespace w5
{
    public interface Target
    {
        string GetRequest();

    }

    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific Request";

        }
    }

    class Adapter: Target
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;

        }
        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            Target target = new Adapter(adaptee);
            Console.WriteLine("Adaptee interface is in incompatible with the client.");
            Console.WriteLine("But with  adapter clint can call it's method.");
            Console.WriteLine(target.GetRequest());

        }
    }
}
