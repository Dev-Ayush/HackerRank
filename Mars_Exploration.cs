//https://www.hackerrank.com/challenges/mars-exploration

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Exploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine().ToUpper();
            /*
            char[] s_val = S.ToCharArray();
            int diffrence_of_s = 0;
            int diffrence_of_o = 0;


            if (s_val.Length % 3 ==0)
            {
                int num_of_words = s_val.Length / 3;
                int total_num_of_s_that_world_should_have = num_of_words * 2 ;

                int actual_count_of_s = s_val.Count(x => x == 'S');
                int actual_count_no_of_o = s_val.Count(x => x == 'O');

                diffrence_of_s = total_num_of_s_that_world_should_have - actual_count_of_s;
                diffrence_of_o = num_of_words - actual_count_no_of_o;
            }
            Console.WriteLine(diffrence_of_s + diffrence_of_o);
            */

            int count = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if ((i % 3) == 1 && S[i] != 'O')
                    count++;
                else if ((i % 3) != 1 && S[i] != 'S')
                    count++;
            }

            Console.Write(count);
            Console.ReadLine();
        }
    }
}
