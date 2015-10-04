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
         
            Console.WriteLine("[X]>");
         

            string parsed = Console.ReadLine();
            var Parse = new InputParser();
            

            ParseResponse.Parse(parsed);
            Console.WriteLine("= " + parsed );

            var NewParse= Console.ReadLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
        //Add a COUNTER() 
    }
}
