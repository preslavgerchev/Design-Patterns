using System.Collections.Generic;

namespace StrategyPattern
{
    public class OperatingSystem
    {
        public List<int> Numbers { get; }
        public int CurrentNumber { get; set; }
        public IDiskReadingStrategy DiskReadingStrategy { get; set; }

        public OperatingSystem()
        {
            Numbers = new List<int>();
            DiskReadingStrategy = new FCFSReadingStrategy();
        }

        public int ReadNumber()
        {
            CurrentNumber=DiskReadingStrategy.NextNumber(Numbers, CurrentNumber);
            return CurrentNumber;
        }
    }
}