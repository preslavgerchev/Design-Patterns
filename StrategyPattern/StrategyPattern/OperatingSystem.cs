using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class OperatingSystem
    {
        //random number generator to generate numbers for the list.
        private Random numberGenerator;
        private const int LIST_SIZE = 15;

        public List<int> Numbers { get; }
        public int CurrentNumber { get; set; }
        public IDiskSchedulerStrategy DiskReadingStrategy { get; set; }

        public OperatingSystem(IDiskSchedulerStrategy diskReadingStrategy)
        {
            Numbers = new List<int>();
            numberGenerator = new Random();
            DiskReadingStrategy = diskReadingStrategy;
            PopulateNumbersList();
            CurrentNumber = Numbers[0];
        }

        /// <summary>
        ///Delegating method to get the next number from the IDiscScheduler.
        /// </summary>
        /// <returns>After assigning the current number it is returned.</returns>
        public int ReadNumber()
        {
            CurrentNumber=DiskReadingStrategy.NextNumber(Numbers, CurrentNumber);
            return CurrentNumber;
        }

        /// <summary>
        /// Fills the list with numbers.Used to keep the disc scheduler going on.
        /// </summary>
        public void PopulateNumbersList()
        {
            for (int i = Numbers.Count; i < LIST_SIZE; i++)
            {
                int randomNumber = numberGenerator.Next(1, 101);
                while (Numbers.Contains(randomNumber))
                {
                    randomNumber = numberGenerator.Next(1, 101);
                }
                Numbers.Add(randomNumber);
            }
        }
    }
}