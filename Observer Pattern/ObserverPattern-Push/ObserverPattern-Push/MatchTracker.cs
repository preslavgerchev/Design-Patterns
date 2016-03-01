using System.Collections.Generic;

namespace ObserverPattern_Push
{
    public class MatchTracker : ISubject
    {
        public int HomeSideScore { get; set; }
        public int GuestSideScore { get; set; }
        private IList<IObserver> observers;

        public MatchTracker()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver newObserver)
        {
            this.observers.Add(newObserver);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void RemoveObserver(IObserver removeObserver)
        {
            this.observers.Remove(removeObserver);
        }
        public void UpdateScore(int homeSideScore, int guestSideScore)
        {
            this.HomeSideScore = homeSideScore;
            this.GuestSideScore = guestSideScore;
            NotifyObservers();
        }
    }
}