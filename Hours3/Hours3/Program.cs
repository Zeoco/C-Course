using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay = 0;
            double rate = 0;
            double hours = 0;

            // Gets hours and rate to output pay
            Console.WriteLine("Enter Hours: ");
            string hrs = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter Rate: ");
            string rte = Console.ReadLine();

            // Convert to string input to double
            try
            {
                hours = Convert.ToDouble(hrs);
                rate = Convert.ToDouble(rte);
            }
            catch
            {
                Console.WriteLine("---- Invalid Input ----");
                Console.ReadLine();                
            }

            // Takes into consideration overtime at x1.5 after 40 hrs
            if (hours <= 40)
            {
                pay = hours * rate;
            }
            else
            {
                pay = rate * 40 + (rate * 1.5 * (hours - 40));
            }

            Console.WriteLine();
            Console.WriteLine("Your payment is: ${0}", pay);
            Console.ReadLine();

        }
    }
}
