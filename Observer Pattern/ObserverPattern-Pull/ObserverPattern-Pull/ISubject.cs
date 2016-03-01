namespace ObserverPattern_Pull
{
    public interface ISubject
    {
        void AddObserver(IObserver newObserver);
        void RemoveObserver(IObserver removeObserver);
        void NotifyObservers();
    }
}