using System;
using System.Collections.Generic;
using FizzBuzzObserver.Interfaces;
using FizzBuzzObserver.Models;

namespace FizzBuzzObserver
{
    public class FizzBuzzData : ISubject
    {
        private readonly IValueGenerator _valueGenerator;
        private readonly List<IObserver> _observers;

        public FizzBuzzData(IValueGenerator valueGenerator)
        {
            _valueGenerator = valueGenerator;
            _observers = new List<IObserver>();
        }

        public void GenerateData(int upperbound, List<NumberWordPair> pairs)
        {
            for (var i = 1; i <= upperbound; i++)
            {
                var result =_valueGenerator.Generate(i, pairs);
                NotifyObservers(i, result);
            }
        }

        public void RegisterObserver(IObserver newObserver)
        {
            _observers.Add(newObserver);
        }

        public void RemoveObserver()
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers(int currentNumber,string newFizzBuzzValue)
        {
            foreach (var observer in _observers)
            {
                observer.Update(currentNumber, newFizzBuzzValue);
            }
        }
    }
}
