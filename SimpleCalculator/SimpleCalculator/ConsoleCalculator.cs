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
    }
}
