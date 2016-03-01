using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class SCANSchedulerStrategy : IDiskSchedulerStrategy
    {
        private bool goingDown = true;

        /// <summary>
        /// Returns the next or the previous number in the list(elevator). 
        /// Depends on whether the elevator is going downwards or upwards
        /// </summary>
        /// <param name="numbers">The list of numbers that is passed to the disk scheduler.</param>
        /// <param name="currentNumber">The current number that is being read.</param>
        /// <returns>The next number that should be read.</returns>
        public int NextNumber(IList<int> numbers, int currentNumber)
        {
            //determines if the elevator should go up or down.
            goingDown = goingDown ?
            numbers.Where(n => n > currentNumber).Count() > 0 :
            numbers.Where(n => n < currentNumber).Count() == 0;

            //based on the direction returns either the next or the previous number.
            return goingDown ?
            numbers.Where(n => n > currentNumber).OrderBy(n => n).First() :
            numbers.Where(n => n < currentNumber).OrderBy(n => n).Last();
        }
    }
}