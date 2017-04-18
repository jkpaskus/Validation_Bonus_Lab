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
            Console.Write("Enter a number boss: ");
            string prompt = Console.ReadLine();
            int value = GetInt(prompt);
            Console.WriteLine("Here is the value: {0}", value);
           
        }

        public static int GetInt(string prompt)
        {
            int value;
            if(!int.TryParse(prompt, out value))
            {
                Console.WriteLine("Please enter a proper NUMERIC integer!!");

            } return value;
            
        }
    }
}
