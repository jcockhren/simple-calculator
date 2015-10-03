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
        private static readonly bool result;

        private int FirstInt { get; set; }
        private int SecondInt { get; set; }
        private char Operation { get; set; }
        public int answer { get; private set; }
        public static int numberOfOperators { get; private set; }

        internal static void Parse(string response)
        {
            // throw new NotImplementedException();
        }

        public int Response(int FirstInt, int SecondInt, char Operation)
        {

            Char[] delimiterChars = { '+', '-', '*', '/', '%' };

            // String userEquation = Response();
            // String[] result = userEquation.Split(delimiterChars);
            // String result = Response();

            string s = new string(delimiterChars);
            String[] response = InputParser.Split(delimiterChars);
            foreach (char delimiterChar in delimiterChars)

            // System.Console.WriteLine(s);

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



        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public class ParsedInput
        {
            public int FirstInt;
            public int SecondInt;
            public char Operation;
        }

        public ParsedInput ParseInput(string consoleInput)
        {
            string operators = "+-*       /%";
            int numberOfOperators = 0;
            char operatorSymbol;

        foreach(char operator in operators)
        {
            if (consoleInput.IndexOf(operatorSymbol) != -1)
            {
                numberOfOperators++;
            }
            
            }
         }
            if(numberOfOperators == 1)
        {
            int index;
            foreach(char operatorSymbol in operators)
            {
                if (consoleInput.IndexOf(operator) != -1)
                {
                    index = consoleInput.IndexOf(operator);
                    operator = consoleInput[index];
                       
                }
                
            }
            string[] splitInput = consoleInput.Split(operator);
            int firstInt = int.Parse(splitInput[0]);
            int secondInt = int.Parse(splitInput[1]);
            ParsedInput parsed = new ParsedInput();
            parsed.firstInt = firstInt;
            parsed.SecondInt = secondInt;
            parsed.operator = operator;
            return parsed;



                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        } 

    }

    //    private string Response()
      //  {
         //   throw new NotImplementedException();
     //   }

        //internal static void Parse(string response)
    //  {
           // Console.WriteLine(response);
     //   }
   // }
}

//1+1 pass parsing class find operan that splits numbers 