namespace FizzBuzzObserver.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver newObserver);
        void RemoveObserver();
        void NotifyObservers(int currentNumber, string newFizzBuzzValue);
    }
}