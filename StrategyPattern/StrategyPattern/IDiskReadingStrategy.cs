using System.Collections.Generic;

namespace StrategyPattern
{
    public interface IDiskReadingStrategy
    {
        int NextNumber(IList<int> numbers,  int currentNumber);
    }
}