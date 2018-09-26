using System;
using System.Collections.Generic;
using FizzBuzzObserver.Net.Models;

namespace FizzBuzzObserver.Net
{
    public class FizzBuzzData : IObservable<FizzBuzzDto>
    {
        private readonly IValueGenerator _valueGenerator;
        private readonly List<IObserver<FizzBuzzDto>> _observers;

        public FizzBuzzData(IValueGenerator valueGenerator)
        {
            _valueGenerator = valueGenerator;
            _observers = new List<IObserver<FizzBuzzDto>>();
        }

        public void GenerateData(int upperbound, List<NumberWordPair> pairs)
        {
            for (var i = 1; i <= upperbound; i++)
            {
                var result = _valueGenerator.Generate(i, pairs);
                NotifyObservers(new FizzBuzzDto{CurrentNumber = i, Value = result});
            }
        }

        public IDisposable Subscribe(IObserver<FizzBuzzDto> observer)
        {
            _observers.Add(observer);

            return new Unsubscriber<FizzBuzzDto>(_observers, observer);
        }

        public void NotifyObservers(FizzBuzzDto data)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(data);
            }
        }
    }
}