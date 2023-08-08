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

        public int TwinNumberCounter()
        {
            int[] ints = { 1, 3, 7, 7, 5, 3, 2, 2, 2, 2};
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
