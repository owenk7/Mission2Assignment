using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1 % of the total number of rolls. \nTotal number of rolls = " + numRolls + ".");

            // random number generator
            Random r = new Random();

            // creation of array
            int[] rollcountArray = new int[13];

            // random number range
            rollcountArray[0] = r.Next(6);

            // simulate the roll of the die, dice1 and dice2
            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = r.Next(1,7);
                int dice2 = r.Next(1,7);

                int diceTotal = dice1 + dice2;

                rollcountArray[diceTotal]++;
            }

            // print the results from the array
            for (int i = 2; i <= 12; i++)
            {
                // show a * in place of 1% of the roll count
                int calcPerc = (int)((double)rollcountArray[i] / numRolls * 100);

                Console.Write(i + ": ");
                for (int x = 0; x < calcPerc; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("I hope you enjoyed counting all those little asterisks! Goodbye!!");

        }
    }
}
