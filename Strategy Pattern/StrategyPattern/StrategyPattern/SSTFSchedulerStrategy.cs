using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class SSTFSchedulerStrategy : IDiskSchedulerStrategy
    {
        /// <summary>
        /// Returns the closest number to the current one (shortest seek time).
        /// </summary>
        /// <param name="numbers">The list of numbers that is passed to the disk scheduler.</param>
        /// <param name="currentNumber">The current number that is being read.</param>
        /// <returns>The next number that should be read.</returns>
        public int NextNumber(IList<int> numbers, int currentNumber)
        {
            //excludes the current number and compares it with all others(absolute difference) and returns the closest one.
            return numbers
                .Where(n => n != currentNumber)
                .Aggregate((x, y) => Math.Abs(x - currentNumber) < Math.Abs(y - currentNumber) ? x : y);
        }
    }
}