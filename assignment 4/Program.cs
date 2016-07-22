using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] diceRolls = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            int[] tally = new int[13];
            int maxRolls = 36000;

            // builds the array
            for (int index = 0; index < maxRolls; index++)
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
            for (int index = 2; index < 13; index++)
            {
                Console.WriteLine("{0}: {1} ", index, tally[index]);
            }


        }
    }
}

