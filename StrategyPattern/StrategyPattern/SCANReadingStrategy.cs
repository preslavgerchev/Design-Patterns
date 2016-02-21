using System.Collections.Generic;

namespace StrategyPattern
{
    public class SCANReadingStrategy : IDiskReadingStrategy
    {
        private bool goingDown;

        public int NextNumberPosition(IList<int> numbers, int currentPosition)
        {
            //evalute if up or down only on first or last position
            if (currentPosition == 0 || currentPosition == numbers.Count - 1)
            {
                goingDown = currentPosition < numbers.Count - 1;
            }
            return goingDown ? ++currentPosition : --currentPosition;
        }
    }
}