using System;

namespace ObserverPattern_Pull
{
    public class MatchDrawObserver : IObserver
    {
        public ISubject Subject { get; }
        public bool MatchIsDraw { get; private set; }
        public int HomeSideScore { get; private set; }
        public int GuestSideScore { get; private set; }
        public Action OnUpdate;

        public MatchDrawObserver(ISubject subject)
        {
            this.Subject = subject;
            Subject.AddObserver(this);
        }
        public void Update(MatchTracker matchTracker)
        {
            if (HomeSideScore != matchTracker.HomeSideScore || GuestSideScore != matchTracker.GuestSideScore)
            {
                this.HomeSideScore = matchTracker.HomeSideScore;
                this.GuestSideScore = matchTracker.GuestSideScore;
                MatchIsDraw = HomeSideScore == GuestSideScore;
                OnUpdate();
            }
        }

        public override string ToString()
        {
            return MatchIsDraw ? "Match is currently draw!" : "Match isnt currently draw!";
        }
    }
}