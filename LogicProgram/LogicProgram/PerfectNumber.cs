 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPrograms
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int n;
            int sum;

            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            sum = 0;
            Console.WriteLine("The positive divisor are: ");

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write(" {0} ", i);

                }
            }
            Console.Write("\nThe sum of divisor is: {0}", sum);
            if (sum == n)
            {
                Console.Write("\nThe number is perfect.");
            }
            else
            {
                Console.Write("\nThe number is not perfect.");
            }
            Console.Write("\n");
        }
    }
}