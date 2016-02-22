using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class OperatingSystem
    {
        private const int LIST_SIZE = 15;
        private static readonly Random randomNumberGenerator = new Random();
        public List<int> Numbers { get; set; }
        public int CurrentNumber { get; set; }
        public IDiskSchedulerStrategy DiskSchedulerStrategy { get; set; }

        public OperatingSystem(IDiskSchedulerStrategy diskSchedulerStrategy)
        {
            Numbers = new List<int>();
            PopulateNumbersList();
            DiskSchedulerStrategy = diskSchedulerStrategy;
            CurrentNumber = Numbers[0];
        }

        /// <summary>
        ///Delegating method to get the next number from the IDiscScheduler.
        /// </summary>
        /// <returns>After assigning the current number it is returned.</returns>
        public int NextNumber()
        {
            CurrentNumber = DiskSchedulerStrategy.NextNumber(Numbers, CurrentNumber);
            return CurrentNumber;
        }

        /// <summary>
        /// Fills the list with numbers.Used to keep the disc scheduler going on.
        /// </summary>
        public void PopulateNumbersList()
        {
            for (int i = Numbers.Count; i < LIST_SIZE; i++)
            {
                int randomNumber = randomNumberGenerator.Next(1, 101);
                while (Numbers.Contains(randomNumber))
                {
                    randomNumber = randomNumberGenerator.Next(1, 101);
                }
                Numbers.Add(randomNumber);
            }
        }
    }
}