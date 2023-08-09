using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class TaskClassTester
    {
        [Fact]
        public void NumberSelecterSchuldReturnBiggest()
        {
            //arange
            int[] testints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int biggestint = testints[0];
            foreach (int i in testints)
            {
                if (i > biggestint)
                {
                    biggestint = i;
                }
            }
            int Expected = biggestint;
            //act

            //assert
        }
    }
