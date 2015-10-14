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
            int x = 0;
            for (int i = 0; i <= x; i++)
                Console.WriteLine("["+ Counter.IncreaseCounter(i++) + "]>");
         

            string input = Console.ReadLine();
            var calculator = new ConsoleCalculator();
            var result = calculator.Calculate(input);
       
            Console.WriteLine("= " + result );

            //   int i = 0;
            
                // return i;
            //Console.WriteLine("[" + i++ + "]>");


            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
        //Add a COUNTER() 
        //add loop to run program again While Loop?
    }
}
