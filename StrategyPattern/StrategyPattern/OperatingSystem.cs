using System.Collections.Generic;

namespace StrategyPattern
{
    public class OperatingSystem
    {
        public List<int> Numbers { get; }
        public int CurrentPosition { get; set; } = 0;
        public IDiskReadingStrategy DiskReadingStrategy { get; set; }

        public OperatingSystem()
        {
            Numbers = new List<int>();
            DiskReadingStrategy = new SSTFReadingStrategy();
        }

        public int ReadNumber()
        {
            return DiskReadingStrategy.NextNumberPosition(Numbers, CurrentPosition);
        }
    }
}