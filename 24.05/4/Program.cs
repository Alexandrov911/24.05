using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.50 в
            Console.WriteLine("введите натуральное число x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число k");
            int k = Convert.ToInt32(Console.ReadLine());

            int k1 = 0;
           
            while (x != 0)
            {
                int c = x % 10;
                if (c == a)
                {
                    k1++;
                }
                
            }
            if (k1!= 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();

        }
    }
}
