using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputParser Parse = new InputParser();
            Console.WriteLine("Enter an Equation [0]>");
            string response = Console.ReadLine();

            ParseResponse.Parse(response);
            
        }

    }
}
