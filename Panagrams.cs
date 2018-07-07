//https://www.hackerrank.com/challenges/pangrams/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToUpper().Trim().Replace(" ","");
            StringBuilder sb = new StringBuilder(s);
            char[] myList = new char[sb.Length];
            if (sb.Length < 26)
            {
                Console.WriteLine("not pangram");
            }
            else
            {
                for(int i=0;i<sb.Length;i++)
                {
                    char z = sb[i];
                    myList[i] = z;
                }
                if(isAvailable(myList))
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    Console.WriteLine("not pangram");
                }
            }
            
        }
        static bool isAvailable(char[] allList)
        {
            if (
            allList.Contains('A') &&
            allList.Contains('B') &&
            allList.Contains('C') &&
            allList.Contains('D') &&
            allList.Contains('E') &&
            allList.Contains('F') &&
            allList.Contains('G') &&
            allList.Contains('H') &&
            allList.Contains('I') &&
            allList.Contains('J') &&
            allList.Contains('K') &&
            allList.Contains('L') &&
            allList.Contains('M') &&
            allList.Contains('N') &&
            allList.Contains('O') &&
            allList.Contains('P') &&
            allList.Contains('Q') &&
            allList.Contains('R') &&
            allList.Contains('S') &&
            allList.Contains('T') &&
            allList.Contains('U') &&
            allList.Contains('V') &&
            allList.Contains('W') &&
            allList.Contains('X') &&
            allList.Contains('Y') &&
            allList.Contains('Z')
                )
                return true;
            else
            {
                return false;
            }
        }
        
    }
}
