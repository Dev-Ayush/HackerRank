//https://www.hackerrank.com/challenges/bon-appetit/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Appetite
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n_k = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(n_k[0]);
            int k = Convert.ToInt32(n_k[1]);
            string[] temp = Console.ReadLine().Split(' ');
            int[] price = Array.ConvertAll(temp,Int32.Parse);
            int amountCharged = Convert.ToInt32(Console.ReadLine());

            int amountNotEaten = price[k];
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                sum += price[i];
            }
            int amountThatShouldBeShared = ((sum - amountNotEaten) / 2);
            if(amountThatShouldBeShared==amountCharged)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(amountCharged-amountThatShouldBeShared);
            }
        }
    }
}
