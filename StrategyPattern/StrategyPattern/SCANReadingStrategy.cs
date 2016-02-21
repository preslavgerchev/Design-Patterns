using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class SCANReadingStrategy : IDiskReadingStrategy
    {
        private bool goingDown = true;

        public int NextNumber(IList<int> numbers, int currentNumber)
        {
            goingDown = goingDown ?
            numbers.Where(n => n > currentNumber).Count() > 0 :
            numbers.Where(n => n < currentNumber).Count() == 0;

            return goingDown ?
            numbers.Where(n => n > currentNumber).OrderBy(n => n).First() :
            numbers.Where(n => n < currentNumber).OrderBy(n => n).Last();
        }
    }
}