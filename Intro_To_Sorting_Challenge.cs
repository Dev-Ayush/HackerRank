using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Take an array of elemnts and search a aparticluar number to display it's index number 
namespace Intro_To_Sorting_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            
            int[] ar = new int[n];
            string[] input = Console.ReadLine().Split();

            for (int j =0;j < ar.Length;j++)
            {
                 ar[j] = int.Parse(input[j]);
            }
            

            int i = 0;
            while(i<n && V != ar[i])
            {
                i++;
            }
            if(i<n)
            {
                Console.Write(i);
            }

            Console.ReadLine();
        }
    }
}
