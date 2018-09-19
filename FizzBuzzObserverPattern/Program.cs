using System;
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
            var counterObserver = new Counter();
            var writerObserver = new Writer();

            subject.RegisterObserver(counterObserver);
            subject.RegisterObserver(writerObserver);

            subject.GenerateData(upperbound, data);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total numbers crunched: " + counterObserver.CurrentCount);
            Console.WriteLine("Numbers changed to words: " + counterObserver.NumberOfValuesModifed);

            Console.ReadKey();
        }
    }
}
