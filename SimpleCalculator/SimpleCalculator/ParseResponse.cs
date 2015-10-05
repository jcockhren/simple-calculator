using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    public class ParseResponse
    {
       // private static readonly bool result;

        private int FirstInt { get; set; }
        private int SecondInt { get; set; }
        private char Operation { get; set; }
        public int answer { get; private set; }
        public static int numberOfOperators { get; private set; }
        public char[] operatorSymbol { get; private set; }


        public int Response(int FirstInt, int SecondInt, char Operation)
        {

            Char[] delimiterChars = { '+', '-', '*', '/', '%' };

             String userEquation = Response();
             String[] result = string.Split(delimiterChars);
             String result = Response();
       
            string s = new string(delimiterChars);
            String[] response = InputParser.Split(delimiterChars);
            foreach (char delimiterChar in delimiterChars)

             System.Console.WriteLine(s); 
           
            {

                switch (Operation)
                {
                    case '+':
                        return FirstInt + SecondInt;
                    case '-':
                        return FirstInt - SecondInt;
                    //break;
                    case '*':
                        return FirstInt * SecondInt;
                    // break;
                    case '/':
                        return FirstInt / SecondInt;
                    // break;
                    case '%':
                        return FirstInt % SecondInt;
                    // break;
                    default:
                        throw new ArgumentException("incorrect format");
                        // break;
                }

            }
            return answer;
        }


        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class ParsedInput
        {
            public int FirstInt;
            public int SecondInt;
            public char Operation;
          //  internal char[] operatorS;

            public char operatorSymbol { get; internal set; }
        }

        public ParsedInput ParseInput(string consoleInput)
        {
            string operators = "+-*/%";
            int numberOfOperators = 0;
            char operatorSymbol;

            foreach (char operatorSymbol in operators)
            {
                if (consoleInput.IndexOf(operatorSymbol) != -1)
                {
                    numberOfOperators++;
                }
                throw new ArgumentException();
            }
            if (numberOfOperators == 1)
            {
                int index;
                foreach(char operatorSymbol in operators)
                {
                    if (consoleInput.IndexOf(operatorSymbol) != -1)
                    {
                        index = consoleInput.IndexOf(operatorSymbol);
                        operatorS = consoleInput[index];

                    }
                    throw new ArgumentException();
                }
                

                string[] splitInput = consoleInput.Split(operatorSymbol);
                int FirstInt = int.TryParse(parsed, out FirstInt);
                int SecondInt = int.TryParse(parsed, out SecondInt);
                ParsedInput parsed = new ParsedInput();
                parsed.FirstInt = FirstInt;
                parsed.SecondInt = SecondInt;
                parsed.operatorSymbol = operatorSymbol;
                return parsed;



                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            }
             throw new ArgumentException();
        }

    }
}
//1+1 pass parsing class find operan that splits numbers 