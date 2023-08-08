using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unittest
{
    public class TaskClass
    {
        public void TableCreator()
        {
            int[] teller1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] teller2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int telleri in teller1)
            {
                foreach (int tellerii in teller2)
                {
                    Console.Write(telleri * tellerii);
                }
                Console.WriteLine();
            }
        }

        public int NumberSelecter()
        {
            int[] ints = { 190, 291, 145, 209, 280, 200 };
            int biggestint = ints[0];
            foreach (int i in ints)
            {
                if (i > biggestint)
                {
                    biggestint = i;
                }
            }
            return biggestint;
        }
    }
}
