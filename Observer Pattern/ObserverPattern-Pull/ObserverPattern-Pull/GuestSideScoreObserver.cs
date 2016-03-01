using System;

namespace ObserverPattern_Pull
{
    public class GuestSideScoreObserver : IObserver
    {
        public ISubject Subject { get; }
        public int GuestSideScore { get; private set; }
        public Action OnUpdate;

        public GuestSideScoreObserver(ISubject subject)
        {
            this.Subject = subject;
            subject.AddObserver(this);
        }

        public override string ToString()
        {
            return this.GuestSideScore.ToString();
        }

        public void Update(MatchTracker matchTracker)
        {
            if (GuestSideScore != matchTracker.GuestSideScore)
            {
                this.GuestSideScore = matchTracker.GuestSideScore;
                OnUpdate();
            }
        }
    }
}