//https://www.hackerrank.com/challenges/sock-merchant

using System;

class Solution
{

    static void Main(String[] args)
    {
        int counter = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = i + 1; j < c.Length; j++)
            {
                if (c[i] == c[j] && c[i] != 0)
                {
                    counter++;
                    c[i] = 0;
                    c[j] = 0;
                }

            }

        }
        Console.WriteLine(counter);
        Console.ReadKey();
    }
}
