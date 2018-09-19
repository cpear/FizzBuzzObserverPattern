using FizzBuzzObserver.Interfaces;

namespace FizzBuzzObserver.Observers
{
    public class Counter : IObserver
    {
        public int CurrentCount { get; private set; }
        public int NumberOfValuesModifed { get; private set; }

        public void Update(int currentNumber, string value)
        {
            NumberOfValuesModifed++;

            if (value == currentNumber.ToString())
            {
                CurrentCount++;
            }
        }
    }
}