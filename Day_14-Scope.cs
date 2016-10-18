https://www.hackerrank.com/challenges/30-scope

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public  Difference(int[] temp)
        {
            this.elements = temp;
        }

        public void computeDifference()
        {
            /*
            int n = elements.Length;
            int max = 0;
            int result = 0;
            for(int i=n-1;i>=0;i--)
            {
                if(elements[i] > max)
                {
                    max = elements[i];
                }
                var tmpRes = max - elements[i];
                if (tmpRes > result)
                    result = tmpRes;
                maximumDifference = result;
            }*/

            int diff = 0;
            for(int i=0;i<elements.Length;i++)
            {
                for(int j=i+1;j<elements.Length;j++)
                {
                    if(Math.Abs(elements[j]-elements[i]) > diff)
                    {
                        diff = Math.Abs(elements[j] - elements[i]);
                    }
                }
            }
            maximumDifference = diff;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
