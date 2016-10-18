//https://www.hackerrank.com/challenges/a-very-big-sum

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            
            string[] temp_storage = new string[N];
            int[] temp_int_storage = new int[N];

            temp_storage = (Console.ReadLine().Split(' '));

            temp_int_storage = Array.ConvertAll(temp_storage, int.Parse);

            long sum_of_all_elements_of_array = 0;
            for(int i=0;i< temp_int_storage.Length;i++)
            {
                sum_of_all_elements_of_array = sum_of_all_elements_of_array  + temp_int_storage[i];
            }

            Console.WriteLine(sum_of_all_elements_of_array);

            Console.ReadLine();
        }
    }
}
