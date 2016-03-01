using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern;
using System.Collections.Generic;

namespace StrategyPatternUnitTesting
{
    [TestClass]
    public class StrategyPatternTesting
    {
        [TestMethod]
        public void TestFCFSSchedulerStrategy()
        {
            var operatingSystemNumbers = new List<int>() { 45, 3, 78, 56, 34, 26, 44, 24, 12, 7, 6, 99, 100, 87, 49 };
            System.Console.Out.WriteLine(operatingSystemNumbers.Count);
            OperatingSystem os = new OperatingSystem(new FCFSSchedulerStrategy());
            os.Numbers = operatingSystemNumbers;
            int nextNumber = os.NextNumber();
            int expectedNumber = os.Numbers[0];
            Assert.AreEqual(nextNumber, expectedNumber);
        }

        [TestMethod]
        public void TestSCANSchedulerStrategy()
        {
            var operatingSystemNumbers = new List<int>() { 45, 3, 78, 56, 34, 26, 44, 24, 12, 7, 6, 99, 100, 87, 49 };
            OperatingSystem os = new OperatingSystem(new SCANSchedulerStrategy());
            os.Numbers = operatingSystemNumbers;
            os.CurrentNumber = os.Numbers[0];
            int nextNumber = os.NextNumber();
            int expectedNumber = 49;//the next number after 45 when going down.
            Assert.AreEqual(nextNumber, expectedNumber);
        }

        [TestMethod]
        public void TestSSTFSchedulerStrategy()
        {
            var operatingSystemNumbers = new List<int>() { 45, 3, 78, 56, 34, 26, 44, 24, 12, 7, 6, 99, 100, 87, 49 };
            OperatingSystem os = new OperatingSystem(new SSTFSchedulerStrategy());
            os.Numbers = operatingSystemNumbers;
            os.CurrentNumber = os.Numbers[0];
            int nextNumber = os.NextNumber();
            int expectedNumber = 44;//closest to 45.
            Assert.AreEqual(nextNumber, expectedNumber);
        }
    }
}