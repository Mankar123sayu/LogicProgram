using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class NumberPrime
    {
        public void Prime()
        {
            int x;
            int flag = 0;
            Console.Write("Enter the number: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("{0} is not a prime number", x);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("{0} is a prime number", x);
            }

            //Console.WriteLine();
        }
    }
}