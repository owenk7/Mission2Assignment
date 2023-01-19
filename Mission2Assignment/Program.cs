﻿using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS Each \"*\" represents 1 % of the total number of rolls. Total number of rolls = " + numRolls + ".");

            // random number generator
            Random r = new Random();

            // creation of array
            int[] rollcountArray = new int[13];

            // random number range
            rollcountArray[0] = r.Next(6);

            // simulate the roll of the die
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
                int percentage = (int)((double)rollcountArray[i] / numRolls * 100);

                Console.Write(i + ": ");
                for (int x = 0; x < percentage; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                //Console.WriteLine((i + 1) + ": " + rollcountArray[i]);
            }

        }
    }
}