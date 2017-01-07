using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay = 0;
            double rte = 0;
            double hrs = 0;

            // Gets hours and rate to output pay
            Console.WriteLine("Enter Hours: ");
            string hours = Console.ReadLine();

            Console.WriteLine("Enter Rate: ");
            string rate = Console.ReadLine();

            hrs = Convert.ToDouble(hours);
            rte = Convert.ToDouble(rate);

            // Takes into consideration overtime at x1.5 after 40 hrs
            if(hrs <= 40)
            {
                pay = hrs * rte;
            }
            else
            {
                pay = rte * 40 + (rte * 1.5 * (hrs - 40));
            }
           
            Console.WriteLine();
            Console.WriteLine("Your payment is: ${0}", pay);
            Console.ReadLine();

        }
    }
}
