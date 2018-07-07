//https://www.hackerrank.com/challenges/breaking-best-and-worst-records

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaking_The_Records
{
    class Program
    {

        static int[] getRecord(int[] s)
        {
            int max = s[0];
            int min = s[0];
            int max_counter = 0;
            int min_counter = 0;
            
            for(int i=0;i<s.Length;i++)
            {
                if(s[i] > max)
                {
                    max = s[i];
                    max_counter++;
                }

                if(s[i]<min)
                {
                    min = s[i];
                    min_counter++;
                }
            }

            int[] result = new int[2] { max_counter,min_counter};
            return result;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
