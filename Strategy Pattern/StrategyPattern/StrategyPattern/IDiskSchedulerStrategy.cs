using System.Collections.Generic;

namespace StrategyPattern
{
    public interface IDiskSchedulerStrategy
    {
        int NextNumber(IList<int> numbers,  int currentNumber);
    }
}