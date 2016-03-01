using System;

namespace ObserverPattern_Push
{
    public class MatchObserver : IObserver
    {
        public string Name { get; }
        public MatchTracker Subject { get; }
        public int HomeSideScore { get; private set; }
        public int GuestSideScore { get; private set; }
        public Action OnUpdate;

        public MatchObserver(MatchTracker subject, string name)
        {
            this.Subject = subject;
            subject.AddObserver(this);
            this.Name = name;
        }

        public override string ToString()
        {
            return this.HomeSideScore + " : " + this.GuestSideScore;
        }

        public void Update()
        {
            this.HomeSideScore = Subject.HomeSideScore;
            this.GuestSideScore = Subject.GuestSideScore;
            OnUpdate();
        }
    }
}