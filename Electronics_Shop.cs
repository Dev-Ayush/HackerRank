//https://www.hackerrank.com/challenges/electronics-shop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
            string[] drives_temp = Console.ReadLine().Split(' ');
            int[] drives = Array.ConvertAll(drives_temp, Int32.Parse);
            //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
            int moneySpent = getMoneySpent(keyboards, drives, s);
            Console.WriteLine(moneySpent);
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int s)
        {
            int final_value = -1;
            // Complete this function
            for(int i=0;i<keyboards.Length;i++)
            {
                for(int j=0;j<drives.Length;j++)
                {
                    if(keyboards[i]+drives[j] <= s && keyboards[i] + drives[j] > final_value)
                    {
                        final_value = keyboards[i] + drives[j];
                    }
                    
                }
            }
            return final_value;
        }
    }
}
