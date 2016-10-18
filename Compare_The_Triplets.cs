//https://www.hackerrank.com/challenges/compare-the-triplets

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int Alice_Counter = 0;
            int Bob_Counter = 0;


            if (a0 > b0 && a0 != b0)
            {
                Alice_Counter++;
            }
            else if(a0 < b0 && a0 != b0)
            {
                Bob_Counter++;
            }

            if (a1 > b1 && a1 != b1)
            {
                Alice_Counter++;
            }
            else if(a1 < b1 && a1 != b1)
            {
                Bob_Counter++;
            }
            if(a2>b2 && a2 != b2)
            {
                Alice_Counter++;
            }
            else if(a2 < b2 && a2 != b2)
            {
                Bob_Counter++;
            }
            Console.WriteLine(Alice_Counter + " " + Bob_Counter);

            Console.ReadLine();
        }
    }
}
