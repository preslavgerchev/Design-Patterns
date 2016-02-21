using System.Collections.Generic;

namespace StrategyPattern
{
    public interface IDiskReadingStrategy
    {
        int NextNumberPosition(IList<int> numbers, int currentPosition);
    }
}