using System;
using FizzBuzzObserver.Net.Models;

namespace FizzBuzzObserver.Net.Observers
{
    public class Writer : IObserver<FizzBuzzDto>
    {
        public void OnNext(FizzBuzzDto value)
        {
            Console.WriteLine(value.Value);
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
