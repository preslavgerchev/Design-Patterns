using System.Collections.Generic;

namespace StrategyPattern
{
    public class FCFSReadingStrategy : IDiskReadingStrategy
    {
        public int NextNumberPosition(IList<int> numbers, int currentPosition)
        {
            return 0;
        }
    }
}