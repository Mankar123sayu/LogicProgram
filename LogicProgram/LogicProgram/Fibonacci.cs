using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPrograms
{
    public class Fibonacci
    {
        public void Series()
        {
            int a = 0;
            int b = 1;
            int c;
            int num;

            Console.Write("Enter the Size: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < num; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

        }
    }
}
