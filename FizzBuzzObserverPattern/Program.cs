using System.Collections.Generic;
using FizzBuzzObserver;
using FizzBuzzObserver.Models;
using FizzBuzzObserver.Observers;

namespace FizzBuzzObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<NumberWordPair>
            {
                new NumberWordPair(3, "Fizz"),
                new NumberWordPair(5, "Buzz")
            };

            int upperbound = 100;

            var subject = new FizzBuzzData(new ValueGenerator());
            var observer1 = new Counter();
            var observer2 = new Writer();

            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);

            subject.GenerateData(upperbound, data);
        }
    }
}
