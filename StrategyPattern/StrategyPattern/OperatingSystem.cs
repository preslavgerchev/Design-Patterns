using System.Collections.Generic;

namespace StrategyPattern
{
    public class OperatingSystem
    {
        public List<int> Numbers { get; private set; }
        public int CurrentNumber { get; set; }
        public IDiskSchedulerStrategy DiskReadingStrategy { get; set; }

        public OperatingSystem(IDiskSchedulerStrategy diskReadingStrategy)
        {
            PopulateNumbersList();
            DiskReadingStrategy = diskReadingStrategy;
            CurrentNumber = Numbers[0];
        }

        /// <summary>
        ///Delegating method to get the next number from the IDiscScheduler.
        /// </summary>
        /// <returns>After assigning the current number it is returned.</returns>
        public int NextNumber()
        {
            CurrentNumber = DiskReadingStrategy.NextNumber(Numbers, CurrentNumber);
            return CurrentNumber;
        }

        /// <summary>
        /// Fills the list with numbers.Used to keep the disc scheduler going on.
        /// </summary>
        public void PopulateNumbersList()
        {
            Numbers = new List<int>() { 45, 3, 78, 56, 34, 23, 24, 12, 7, 6, 99, 100, 87, 25, 56, 67, 73, 69, 81, 49 };
        }
    }
}