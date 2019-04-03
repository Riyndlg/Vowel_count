using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }
    }
}
