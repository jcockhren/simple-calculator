using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Program
    {
        //public static bool Operations { get; private set; }

        static void Main(string[] args)
        {
            ///user enters equation in 1+2 format
         
            Console.WriteLine("[X]>");
         

            string input = Console.ReadLine();
         
            Console.WriteLine("= " + input );
          //  Console.WriteLine(Operations);
            var NewParse= Console.ReadLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
        //Add a COUNTER() 
    }
}
