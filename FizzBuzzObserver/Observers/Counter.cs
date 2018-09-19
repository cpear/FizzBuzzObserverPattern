using FizzBuzzObserver.Interfaces;

namespace FizzBuzzObserver.Observers
{
    public class Counter : IObserver
    {
        public int CurrentCount { get; private set; }
        public int NumberOfValuesModifed { get; private set; }

        public void Update(int currentNumber, string value)
        {
            CurrentCount++;

            if (value != currentNumber.ToString())
            {
                NumberOfValuesModifed++;
            }
        }
    }
}