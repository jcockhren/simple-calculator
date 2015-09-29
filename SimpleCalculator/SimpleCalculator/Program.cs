using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            ///user enters equation in 1+2 format
            InputParser Parse = new InputParser();
            Console.WriteLine("[x]>");

            string response = Console.ReadLine();

        
            ParseResponse.Parse(response);
            Console.WriteLine("= ", response );
           Console.WriteLine("Press any key to exit.");
          Console.ReadKey();

        }
        //Add a COUNTER() 
    }
}
