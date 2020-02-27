using System;
using System.Collections.Generic;
using System.Threading;


namespace W05_OBSERVER
{
    public interface Observer
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
    }

    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<Observer> _observer = new List<Observer>();

        public void Attach(Observer obserer)
        {
            Console.WriteLine("Subject:Attached an observer.");
            this._observer.Add(obserer);

        }
        public void Detach(Observer obserer)
        {
            this._observer.Remove(obserer);
            Console.WriteLine("Subject:Detach an observer.");


        }
        public void Notify()
        {
            Console.WriteLine("Subject:Notfying an observer...");

            foreach (var observer in _observer)
            {
                observer.Update(this);
            }
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject:I'm doing something important.");
            this.State = new Random().Next(0, 10);
            Thread.Sleep(15);
            Console.WriteLine("Subject:my state has just changed to : " + this.State);
            this.Notify();
        }
    }

    class ConcreteObserverA : Observer
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA:Reacted to the event.");
            }
        }
    }

    class ConcreteObserverB : Observer
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB:Reacted to the event.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.Detach(observerB);
            subject.SomeBusinessLogic();
        }
    }
}
