using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please write your full name below:");
            //using try catch method to validate user input
            try
            {
                FullName(Console.ReadLine());

            }//end of try
            catch
            {
                Console.WriteLine("You have an error");
            } //end of catch

        }

        static void FullName(string name)

        {
            Console.WriteLine("Hello " + name + ", Have a beautiful day! :)" );
            Console.ReadKey(true);
        }
    }
    }

