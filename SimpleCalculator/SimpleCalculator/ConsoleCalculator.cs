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
        private readonly int leftNumber;
        private int rightNumber;
       

        public string[] GetNumbers(string input)
        {
           
            return input.Split(delimiterChars);
 
        }

        public char GetOperator(string input)
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


            //build operator method
            //Char Operator = char;
            var operans = GetNumbers(input);
            var op = GetOperator(input);
            switch (op)
            {
                case '+':
                    return addition.AddNum(operans); 
                case '-':
                    return Subtraction.SubtractNum(operans); 
                //break;
                case '*':
                    return leftNumber * rightNumber;
                // break;
                case '/':
                    return leftNumber/rightNumber;
                // break;
                case '%':
                    return leftNumber%rightNumber;
                // break;
                default:
                    throw new ArgumentException("incorrect format");
                    // break;
            }


            //use switch to call add and other methods, rework methods
        }

       
    }

}
 
           ///bool parsed = Int32.TryParse(input, out result);
           /// if (!parsed)
            ///Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", input);
