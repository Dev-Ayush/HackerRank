//https://www.hackerrank.com/challenges/caesar-cipher-1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int chars = Int32.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int nextAdd = Int32.Parse(Console.ReadLine());
            char[] listOfChar = new char[chars];
            for (int i = 0; i < chars; i++)
            {
                if (char.IsLetter(str[i]))
                {

                    char a = char.IsUpper(str[i]) ? 'A' : 'a';
                    int c = (int)a + ((int)str[i] - (int)a + nextAdd) % 26;
                    listOfChar[i] = (char)c;
                }
                else
                    listOfChar[i] = str[i];
            }

            Console.WriteLine(listOfChar);
            Console.ReadKey();
        }
    }
}
