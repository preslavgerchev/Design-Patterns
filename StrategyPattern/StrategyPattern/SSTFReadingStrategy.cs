using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class SSTFReadingStrategy : IDiskReadingStrategy
    {
        public int NextNumber(IList<int> numbers, int currentNumber)
        {
            return numbers
                .Where(n => n != currentNumber)
                .Aggregate((x, y) => Math.Abs(x - currentNumber) < Math.Abs(y - currentNumber) ? x : y);
        }
    }
}