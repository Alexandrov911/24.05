using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.34
            int x = 100;
            int n = 0;
            while (n <= 15)
            {
                if (x % 19 == 0)
                {
                    n++;
                    Console.WriteLine(x);

                }
                x++;
            }
            Console.ReadKey();
        }
    }
}
