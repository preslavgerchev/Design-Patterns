using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class SSTFReadingStrategy : IDiskReadingStrategy
    {
        public int NextNumberPosition(IList<int> numbers, int currentPosition)
        {
            int currentNumber = numbers.ElementAt(currentPosition);

            return  numbers.OrderBy(item => Math.Abs(currentNumber- item)).First();   
        }
    }
}