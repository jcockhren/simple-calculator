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
         
            Console.WriteLine("[0]>");
         

            string response = Console.ReadLine();
            InputParser Parse = new InputParser();


            ParseResponse.Parse(response);
            Console.WriteLine("= " + response /*.Split() */);


           Console.WriteLine("Press any key to exit.");

           string NewResponse = Console.ReadLine();
            Console.ReadLine();

        }
        //Add a COUNTER() 
    }
}
