using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class ConsoleCalculator
    {
        private int FirstInt { get; set; }
        private int SecondInt { get; set; }
        private Char[] delimiterChars = { '+', '-', '*', '/', '%' };
        private int LeftInt;
        private int RightInt;

        public string[] GetNumbers(string input)
        {
           
            return input.Split(delimiterChars);
 
        }

        public Char GetOperator(string input)
        {
            foreach (char character in delimiterChars)
            {
                if (input.Contains(character)){
                    return character;
                }

            }
            throw new InvalidOperationException();
        }
        public int Calculate(string input)
        {
            
            //convert string ti Int
            //use switch to call add and other methods, rework methods 
            return ["12", "16"];
           
            var result = Convert.ToInt32(input);
           

        }
        
    }

}
 
           ///bool parsed = Int32.TryParse(input, out result);
           /// if (!parsed)
            ///Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", input);
