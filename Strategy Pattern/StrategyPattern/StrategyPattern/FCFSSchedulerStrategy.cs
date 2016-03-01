using System.Collections.Generic;

namespace StrategyPattern
{
    public class FCFSSchedulerStrategy : IDiskSchedulerStrategy
    {
        /// <summary>
        /// Returns the first number in the list (first come first serve).
        /// </summary>
        /// <param name="numbers">The list of numbers that is passed to the disk scheduler.</param>
        /// <param name="currentNumber">The current number that is being read.</param>
        /// <returns>The next number that should be read.</returns>
        public int NextNumber(IList<int> numbers, int currentNumber)
        {
            return numbers[0];
        }
    }
}