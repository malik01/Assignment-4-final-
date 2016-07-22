using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * author:Shahzaib Malik           
 * student id: 300852792
 * course id: COMP-123
 * version 1.1 //final version
 */ 
  namespace Dice_Rolling_Simulation
{
    /**
     * this is the main driver class of the program
     * its used to simulate dicerolls of two dices
     * and adds the total number of the times each sum 
     * appeared 
     * @method Main(string[])
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            //Random class used to throw die in a random manner
            Random random = new Random();
            int[] diceRolls = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] tally = new int[13];
            //maximmum number the dice is rolled
            int maxRls = 36000;
            for (int i = 0; i < maxRls; i++)
            {
                int firstDie = random.Next(1, 7);
                int secondDie = random.Next(1, 7);
                int dice = firstDie + secondDie;
                tally[dice]++;
                /**
                 * this loop is to display dice rolls by 
                 * removing the comments the loop is covered in
                 * foreach (int result in diceRolls)
                {
                    int roll = diceRolls[dice];
                    Console.Write(roll+" ");
                }
                */
            }
            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine("{0}: {1} ", i, tally[i]);
            }
        }
    }
}

