using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unittest;

namespace Tester
{
    public class TaskClassTester
    {
        TaskClass taskclass = new TaskClass();
        [Fact]
        public void NumberSelecterSchuldReturnBiggest()
        {
            //arange
            int[] testints = { 190, 291, 145, 209, 280, 200 };
            
            //act
            int Actual = taskclass.NumberSelecter(testints);
            //assert
            Assert.Equal(291, Actual);
        }

        [Fact]
        public void TwinNumberCounterSchuldReturnTwins()
        {
            //arange
            int[] testints = { 1, 3, 7, 7, 5, 3, 2, 2, 2, 2 };
            //act
            int Actual = taskclass.TwinNumberCounter(testints);
            //assert
            Assert.Equal(3, Actual);
        }

        [Fact]
        public void TripletsMustReturnTreeNumberStringPlusOne()
        {
            //arange
            bool Expected = true;
            //act
            bool Actual = taskclass.Triplets();
            //assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void TheseventhofEratosthenesSchuldReturnListOfPrimeNumbers()
        {
            List<int> Primenumbers = new List<int>();
            int Expected = 129;

            Primenumbers = taskclass.TheseventhofEratosthenes(30);
            int Actual = 0;
            foreach(int p in Primenumbers)
            {
                Actual = Actual + p;
            }
            Assert.Equal( Expected, Actual);
        }
    }
}
