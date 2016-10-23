//https://www.hackerrank.com/challenges/linkedin-practice-array-left-rotation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Rotate_The_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int n = int.Parse(line1[0]);
            int k = int.Parse(line1[1]);

            string[] values = Console.ReadLine().Split(' ');
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(values[i]);
                //arr[(i + k) % n] = number; // right rotation
                arr[(i + (n - k)) % n] = number; // left rotation
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
