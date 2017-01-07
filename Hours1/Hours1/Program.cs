using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours1
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

            pay = rte * hrs;

            Console.WriteLine();
            Console.WriteLine("Your payment is: ${0}", pay);
            Console.ReadLine();

        }
    }
}
