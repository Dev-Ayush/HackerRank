//https://www.hackerrank.com/challenges/linkedin-practice-caesar-cipher

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] b_new = new int[n];
            int i = 0;
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > 26)
            {
                k = k % 26;
            }

            byte[] ASCIIValues = Encoding.ASCII.GetBytes(s);

            foreach (byte b in ASCIIValues)
            {
                if (b >= 65 && b <= 90)
                {
                    int Change = b + k;
                    if (Change > 90)
                        Change = Change - 26;
                    b_new[i] = Change;
                }

                else if (b >= 97 && b <= 122)
                {
                    int Change = b + k;
                    if (Change > 122)
                        Change = Change - 26;
                    b_new[i] = Change;
                }
                
                else
                {
                    b_new[i] = b;
                }
                i++;
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write(Char.ConvertFromUtf32(b_new[j]).ToArray());
                Console.ReadLine();
            }
        }
    }
}
