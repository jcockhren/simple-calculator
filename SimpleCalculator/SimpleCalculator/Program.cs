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

            ///user enters equation in 1+2 format
            InputParser Parse = new InputParser();
            Console.WriteLine("[0]>");
            string response = Console.ReadLine();
        
            ParseResponse.Parse(response);
            
        }
        //Add a COUNTER() 
    }
}
