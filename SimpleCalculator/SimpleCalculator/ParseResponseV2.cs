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
        public char[] operatorS { get; private set; }

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

             System.Console.WriteLine(s); 
           
           
            return answer;
        }


        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class ParsedInput
        {
            public int FirstInt;
            public int SecondInt;
            public char Operation;
            internal char[] operatorS;

            public char operatorSymbol { get; internal set; }
        }

        public ParsedInput ParseInput(string consoleInput)
        {
            string operators = "+-*/%";
            int numberOfOperators = 0;
            char operatorSymbol;

            foreach (char operatorS in operators)
            {
                if (consoleInput.IndexOf(operatorS) != -1)
                {
                    numberOfOperators++;
                }
                throw new ArgumentException();
            }
            if (numberOfOperators == 1)
            {
                int index;
                foreach(char operatorS in operators)
                {
                    if (consoleInput.IndexOf(operatorS) != -1)
                    {
                        index = consoleInput.IndexOf(operatorS);
                        operatorSymbol = consoleInput[index];

                    }
                    throw new ArgumentException();
                }
                

                string[] splitInput = consoleInput.Split(operatorS);
                int firstInt = int.Parse(splitInput[0]);
                int secondInt = int.Parse(splitInput[1]);
                ParsedInput parsed = new ParsedInput();
                parsed.FirstInt = firstInt;
                parsed.SecondInt = secondInt;
                parsed.operatorS = operatorS;
                return parsed;



                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            }
            {

            /*   switch (Operation)
                {
                    case '+':
                        FirstInt = Convert.ToInt32(FirstInt);
                        SecondInt = Convert.ToInt32(Console.ReadLine());
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
                */
            }
            throw new ArgumentException();
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
}
//1+1 pass parsing class find operan that splits numbers 