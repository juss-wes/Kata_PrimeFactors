using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactors.Tests
{
    [TestClass]
    public class PrimeFactorShould
    {
        [TestMethod]
        public void ReturnEmptyGivenOne()
        {
            // Arrange
            var input = 1;

            // Act
            var result = PrimeFactors.Generate(input);

            // Assert
            Assert.AreEqual(ListContaining(), result);
        }

        [TestMethod]
        public void ReturnOneGivenTwo()
        {
            // Arrange
            var input = 2;

            // Act
            var result = PrimeFactors.Generate(input);

            // Assert
            Assert.AreEqual(ListContaining(1), result);
        }

        [TestMethod]
        public void ReturnThreeGivenThree()
        {
            // Arrange
            var input = 3;

            // Act
            var result = PrimeFactors.Generate(input);

            // Assert
            Assert.AreEqual(ListContaining(3), result);
        }

        [TestMethod]
        public void ReturnTwoAndTwoGivenFour()
        {
            // Arrange
            var input = 4;

            // Act
            var result = PrimeFactors.Generate(input);

            // Assert
            Assert.AreEqual(ListContaining(2,2), result);
        }

        [TestMethod]
        public void ReturnTwoAndThreeGivenSix()
        {
            // Arrange
            var input = 6;

            // Act
            var result = PrimeFactors.Generate(input);

            // Assert
            Assert.AreEqual(ListContaining(2, 3), result);
        }

        [TestMethod]
        public void ReturnThreeTwosGivenEight()
        {
            // Arrange
            var input = 8;

            // Act
            var result = PrimeFactors.Generate(input);

            // Assert
            Assert.AreEqual(ListContaining(2, 2, 2), result);
        }

        [TestMethod]
        public void ReturnTwoThreesGivenNine()
        {
            // Arrange
            var input = 9;

            // Act
            var result = PrimeFactors.Generate(input);

            // Assert
            Assert.AreEqual(ListContaining(3, 3), result);
        }

        /// <summary>
        /// Helper method to generate a list with specific contents more cleanly
        /// </summary>
        /// <param name="integers">Any number of integers that will be in the returned list</param>
        /// <returns>List of the given integer inputs</returns>
        private List<int> ListContaining(params int[] integers)
        {
            var result = new List<int>();

            foreach (var i in integers)
                result.Add(i);

            return result;
        }
    }
}
