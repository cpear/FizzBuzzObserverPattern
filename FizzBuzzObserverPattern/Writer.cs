using System;
using FizzBuzzObserver.Interfaces;

namespace FizzBuzzObserverPattern
{
    public class Writer : IObserver
    {
        public void Update(int currentNumber, string value)
        {
            Console.WriteLine(value);
        }
    }
}