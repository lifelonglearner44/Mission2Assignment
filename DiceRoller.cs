using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    public class DiceRoller
    {
        // Random object for generating random numbers
        private Random random = new Random();

        // Simulate dice rolls and return an array with counts for each sum
        public int[] SimulateDiceRolls(int numRolls)
        {
            // Initialize an array to store the count of each possible sum (2 to 12)
            int[] results = new int[13];
            // Index 0 is not used; results[2] to results[12] represent sums 2 to 12

            // Loop through the specified number of dice rolls
            for (int i = 0; i < numRolls; i++)
            {
                // Generate random numbers for two six-sided dice
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                // Calculate the sum of the two dice
                int sum = dice1 + dice2;

                // Increment the count for the corresponding sum in the results array
                results[sum]++;
            }
            // Return the array with counts for each sum
            return results;
        }
    }
}
