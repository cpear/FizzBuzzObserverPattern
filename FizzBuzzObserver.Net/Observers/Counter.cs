using System;
using FizzBuzzObserver.Net.Models;

namespace FizzBuzzObserver.Net.Observers
{
    public class Counter : IObserver<FizzBuzzDto>
    {
        public int CurrentCount { get; private set; }
        public int NumberOfValuesModifed { get; private set; }

        public void OnNext(FizzBuzzDto value)
        {
            CurrentCount++;

            if (value.Value != value.CurrentNumber.ToString())
            {
                NumberOfValuesModifed++;
            }
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
