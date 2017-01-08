using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviationCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            while (true)
            {
                // The variable declarations
                list.Clear();
                int count = 0;
                double average = 0;
                double total = 0;
                double sd = 0;
                double variance = 0;
                double number = 0;

                Console.WriteLine("**********************************************");
                Console.WriteLine("This operation requires a set of numbers.");

                while (true)
                {
                    // Take string input
                    Console.WriteLine("");
                    Console.WriteLine("Enter a number: ");
                    string input = Console.ReadLine();
                    
                    // Check for no input
                    if(input.Length < 1){
                        break;
                    }
                    // Convert the string input to a double
                    try
                    {
                        number = Convert.ToDouble(input);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
                    // Add the number to the list and increase the count
                    list.Add(number);
                    count += 1;
                }

                average = list.Sum() / count;

                // Set count up for the operation
                count = count - 1;

                // Iterate through the list, getting ip and ip2 and total
                foreach (double item in list)
                {
                    double ip = Convert.ToDouble(item - average);
                    double ip2 = ip * ip;
                    total += ip2;
                }

                // Get the variance and standard deviation using the .Net Pow method
                variance = total / count;
                sd = Math.Pow(variance, .5);

                Console.WriteLine("The average of the set is: {0}", average);
                Console.WriteLine("The variance of the set is: {0}", variance);
                Console.WriteLine("The standard deviation of the set is: {0}", sd);
                Console.WriteLine("");

                // Asking user to rerun or close
                Console.WriteLine("Would you like to use this again? y/n: ");
                string redo = Console.ReadLine();
                if(redo == "y")
                {
                    Console.WriteLine("");
                    continue;
                }
                else
                { break; }
            }
        }
    }
}
