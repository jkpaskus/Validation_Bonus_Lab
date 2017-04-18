using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Bonus_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Test the GetInt validation method.....................................................................
            //Console.Write("Enter a number boss: ");
            //string prompt = Console.ReadLine();
            ////int value = GetInt(prompt);
            //Console.WriteLine("Here is the value: {0}", value);

            //Test the GetIntWithinRange validation method..........................................................................
            //Get prompt argument.
            Console.Write("Enter a number boss: ");
            string prompt = Console.ReadLine();

            //Get MIN value
            Console.WriteLine("What should be the min?");
            string line1 = Console.ReadLine();
            int min = int.Parse(line1);

            //Get MAX value.
            Console.WriteLine("What should be the max?");
            string line2 = Console.ReadLine();
            int max = int.Parse(line2);

            double value = GetDoubleWithinRangeStep1(prompt, min, max);

            GetDoubleWithinRangeStep2(value, min, max);

            ////Test the GetDouble validation method..........................................................................
            //Console.Write("Enter a number boss: ");
            //string prompt = Console.ReadLine();
            //double value = GetDouble(prompt);
            //Console.WriteLine("Here is the value: {0}", value);

        }

        public static int GetInt(string prompt)
        {
            int value;
            if (!int.TryParse(prompt, out value))
            {
                Console.WriteLine("Please enter a proper NUMERIC integer!!");

            } return value;

        }

        public static int GetIntWithinRangeStep1(string prompt, int min, int max)
        {
            int value;
            if (!int.TryParse(prompt, out value))
            {
                Console.WriteLine("Please enter a proper NUMERIC integer!!");

            }
            return value;
        }

        public static void GetIntWithinRangeStep2(int value, int min, int max)
        {
            if (value >= min && value <= max)
            {
                Console.WriteLine("Value {0} is within range and valid!", value);
            }
            else
            {
                Console.WriteLine("Please enter a number that is within the valid range of {0} to {1}!", min, max);
            }

        }

        public static double GetDouble(string prompt)
        {
            double value;
            if (!double.TryParse(prompt, out value))
            {
                Console.WriteLine("Please enter a proper double!!");

            }
            return value;

        }

        public static double GetDoubleWithinRangeStep1(string prompt, int min, int max)
        {
            double value;
            if (!double.TryParse(prompt, out value))
            {
                Console.WriteLine("Please enter a proper NUMERIC double!!");

            }
            return value;
        }

        public static void GetDoubleWithinRangeStep2(double value, int min, int max)
        {
            if (value >= min && value <= max)
            {
                Console.WriteLine("Value {0} is within range and valid!", value);
            }
            else
            {
                Console.WriteLine("Please enter a number that is within the valid range of {0} to {1}!", min, max);
            }

        }

    }
}
