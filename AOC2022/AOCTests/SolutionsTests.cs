using Microsoft.VisualStudio.TestTools.UnitTesting;
using AOCSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AOCSolutions.Tests
{
    [TestClass()]
    public class SolutionsTests
    {
        [TestMethod()]
        public void Day1aTest()
        {
            //Given
            string path = "C:\\Users\\kfbay\\CodingProjects\\AdventOfCode\\AOC2022\\AOCInputs\\TestDay1.txt";
            int expected = 24000;

            //When
            int actual = Solutions.Day1a(path);

            //Then

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Day1bTest()
        {
            //Given
            string path = "C:\\Users\\kfbay\\CodingProjects\\AdventOfCode\\AOC2022\\AOCInputs\\TestDay1.txt";
            int expected = 45000;

            //When
            int actual = Solutions.Day1b(path);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Day2aTest()
        {
            //Given
            string path = "C:\\Users\\kfbay\\CodingProjects\\AdventOfCode\\AOC2022\\AOCInputs\\TestDay2.txt";
            int expected = 15;


            //When
            int actual = Solutions.Day2a(path);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Day2bTest()
        {
            //Given
            string path = "C:\\Users\\kfbay\\CodingProjects\\AdventOfCode\\AOC2022\\AOCInputs\\TestDay2.txt";
            int expected = 12;


            //When
            int actual = Solutions.Day2b(path);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}