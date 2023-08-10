using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unittest
{
    public class TaskClass
    {
        /// <summary>
        /// Writs a 1*1 table to the console.
        /// </summary>
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
        /// <summary>
        /// Takes an array of ints and returns the one with the highest value.
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        public int NumberSelecter(int[] ints)
        {
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
        /// <summary>
        /// Takes an arry of ints and checks how many ints have a partner that is equal to them.
        /// </summary>
        /// <param name="ints"></param>
        /// <returns>The amount of ints with a equal partner as an int.</returns>
        public int TwinNumberCounter(int[] ints)
        {
            bool Twin = false;
            int TwinCount = 0;
            for(int i=0; i<ints.Length-1; i++)
            {
                if (ints[i] == ints[i + 1] && Twin == false)
                {
                    TwinCount++;
                    Twin = true;
                }
                else
                {
                    Twin = false;
                }
            }
            return TwinCount;
        }
        /// <summary>
        /// Returns true if a row of three numbers where every following number is one greater then the last.
        /// </summary>
        /// <returns></returns>
        public bool Triplets()
        {
            int[] ints = { 7, 11, 12, 14, 15, 16, 17, 20, 4 };
            bool Triplets = false;
            int TripletsCount = 0;

            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i]+1 == ints[i + 1])
                {
                    TripletsCount++;   
                }
                else
                {
                    TripletsCount = 0;
                }
               if(TripletsCount >= 3)
                {
                    Triplets= true;
                    break;
                }
            }
            return Triplets;
        }
        /// <summary>
        /// Takes an int value and colects all primenumbers op to that value
        /// </summary>
        /// <param name="endnumber"></param>
        /// <returns>Returns a int list with all the colected prime numbers.</returns>
        public List<int> TheseventhofEratosthenes(int endnumber)
        {
            List<int> primenumbers= new List<int>();
            List<int> numbers = new List<int>();
            for(int i=2; i < endnumber; i++)
            {
                numbers.Add(i);
                primenumbers.Add(i);

            }

            foreach (int i in numbers)
            {
                int j = i;
                for(int ii=0; ii< primenumbers.Count-1; ii++)
                {
                    primenumbers.Remove(i*j);
                    j++;
                }
            }
            return primenumbers;
        }

    }
}
