using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Vowel_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of strings: ");
            int n = int.Parse(Console.ReadLine());
            string[] cases = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter text: ");
                cases[i] = Console.ReadLine();
            }
            int count;
            string test;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                test = cases[i];
                for (int j = 0; j < test.Length; j++)
                {
                    if ((test[j] == 'a') || (test[j] == 'e') || (test[j] == 'o') || (test[j] == 'i') || (test[j] == 'y') || (test[j] == 'u'))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Number of vowel in text: {count}");
            }
            /*string test = Console.ReadLine();
            for (int i = 0; i < test.Length; i++)
            {
                if ((test[i] == 'a') || (test[i] == 'e') || (test[i] == 'o') || (test[i] == 'i') || (test[i] == 'y') || (test[i] == 'u'))
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/
            Console.ReadKey();
        }
    }
}
