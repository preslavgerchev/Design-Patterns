using System;

namespace ObserverPattern_Pull
{
    public class HomeSideScoreObserver : IObserver
    {
        public ISubject Subject { get; }
        public int HomeSideScore { get; private set; }
        public Action OnUpdate;

        public HomeSideScoreObserver(ISubject subject)
        {
            this.Subject = subject;
            subject.AddObserver(this);
        }

        public override string ToString()
        {
            return this.HomeSideScore.ToString();
        }

        public void Update(MatchTracker matchTracker)
        {
            if (HomeSideScore != matchTracker.HomeSideScore)
            {
                this.HomeSideScore = matchTracker.HomeSideScore;
                OnUpdate();
            }
        }
    }
}