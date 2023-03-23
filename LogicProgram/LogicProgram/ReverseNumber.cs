using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            int n;
            int rev = 0;
            int y;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                y = n % 10;
                rev = rev * 10 + y;
                n /= 10;
            }
            Console.WriteLine("Reversed number is: " + rev);
        }

    }
}
