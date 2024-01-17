
namespace Mission2Assignment
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Welcome message asking for the number of dice rolls to simulate
            System.Console.WriteLine("Welcome to the dice throwing simulator!\r\n\nHow many dice rolls would you like to simulate?");

            // Read the user input for the number of dice rolls
            int numRolls = int.Parse(System.Console.ReadLine());

            // Create an instance of the DiceRoller class
            DiceRoller diceRoller = new DiceRoller();

            // Simulate dice rolls and get the results
            int[] results = diceRoller.SimulateDiceRolls(numRolls);

            // Display simulation results header
            System.Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = {numRolls}.\n");

            // For loop thorugh each possible dice roll sum 2-12 to then display a histogram of the results
            for (int i = 2; i <= 12; i++)
            {
                // Calculate the percentage of occurrences for the current sum
                int percentage = results[i] * 100 / numRolls;

                // Create a string of '*' characters based on the percentage
                string histogram = new string('*', percentage);

                // Display the histogram with the current sum and its corresponding '*' representation
                System.Console.WriteLine($"{i}: {histogram}");
            }
            //Goodbye message
            System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
