using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.35
            int x = 500;
            int n = 0;
            while (n <= 20)
            {
                if (x % 19 == 0 && x % 17 == 0)
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
