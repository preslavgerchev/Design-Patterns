namespace ObserverPattern_Push
{
    public interface IObserver
    {
        void Update(int homeSideScore,int guestSideScore);
    }
}