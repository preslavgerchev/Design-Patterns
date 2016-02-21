using System.Collections.Generic;

namespace StrategyPattern
{
    public class FCFSReadingStrategy : IDiskReadingStrategy
    {
        public int NextNumber(IList<int> numbers, int currentNumber)
        {
            return numbers[0];
        }
    }
}