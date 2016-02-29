using System;

namespace ObserverPattern_Pull
{
    public class MatchDrawObserver : IObserver
    {
        public ISubject Subject { get; }
        public bool MatchIsDraw { get; private set; }
        public Action OnUpdate;

        public MatchDrawObserver(ISubject subject)
        {
            this.Subject = subject;
            Subject.AddObserver(this);
        }
        public void Update(MatchTracker matchTracker)
        {
            MatchIsDraw = matchTracker.HomeSideScore == matchTracker.GuestSideScore;
            OnUpdate();
        }

        public override string ToString()
        {
            return MatchIsDraw ? "Match is currently draw!" : "Match isnt currently draw!";
        }
    }
}