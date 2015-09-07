using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Solution
    {
        static void Main(String[] args) 
    {
            int t = Convert.ToInt32(Console.ReadLine());
            int a = t;

            for (int i = 0; i < t; i++)
            {
                
                string Staircase1 = "".PadLeft(a-1, ' ');
                string Staircase2 = "".PadRight(i + 1, '#');
                Console.Write(Staircase1);
                Console.Write(Staircase2);
                Console.WriteLine();
                a--;
            }
            Console.ReadLine();
            
        }
    }
}
