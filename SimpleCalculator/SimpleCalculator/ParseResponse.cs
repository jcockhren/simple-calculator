using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class ParseResponse
    {
        private int firstInt { get; set; }
        private int secondInt { get; set; }
        private char Operation { get; set; }
        public int result { get; private set; }

        ParseResponse(int firstInt, int SecondInt, char Operation)
           
        {
            String[] Split(
                string[] separator,
                 Char[] "+, -, *, /, %,")
            switch (Operation)
            {
                case "+":
                    result = firstInt + SecondInt;
                    break; 
                case "-":
                    result = firstInt - SecondInt;
                    break;
                case "*":
                    result = firstInt * SecondInt;
                    break;
                case "/":
                    result = firstInt / SecondInt;
                    break;
                case "%":
                    result = firstInt / SecondInt;
                    break;
                default:
                    result = 0;
                    break;
            }
        }

        internal static void Parse(string response)
        {
            //throw new NotImplementedException();
        }
    }
}
//1+1 pass parsing class find operan that splits numbers 