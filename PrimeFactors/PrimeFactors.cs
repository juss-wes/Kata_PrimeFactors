using System.Collections.Generic;

namespace PrimeFactors
{
    /// <summary>
    /// Class to handle the prime factor process
    /// </summary>
    public static class PrimeFactors
    {
        /// <summary>
        /// Method to generate the prime factors for a given input
        /// </summary>
        /// <param name="input">Integer to determine the prime factors for</param>
        /// <returns>List of integers found to be primes</returns>
        public static List<int> Generate(int input)
        {
            var primes = new List<int>();

            // Loop through possible primes until input is no longer divisible
            for (var possiblePrime = 2; input > 1; possiblePrime++)
            {
                // When fully divisble
                while(input % possiblePrime == 0)
                {
                    // divide by the identified factor and add it to the list
                    input /= possiblePrime;
                    primes.Add(possiblePrime);
                }
            }

            return primes;
        }
    }
}
