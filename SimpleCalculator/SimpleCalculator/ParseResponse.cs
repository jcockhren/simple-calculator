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

        private int firstInt { get; set; }
        private int SecondInt { get; set; }
        private char Operation { get; set; }
        public int answer { get; private set; }

       public int Response(int firstInt, int SecondInt, char Operation)
        {
           
            Char[] delimiterChars = { '+', '-', '*', '/', '%' };
           // String pattern = @"([-+*/])"; //// ???
             String userEquation = Console.ReadLine();
            String[] result = userEquation.Split(delimiterChars);
            // String result = Response();

            string s = new string(delimiterChars);
             String[] response = userEquation.Split(delimiterChars);
            foreach (char delimiterChar in delimiterChars)

                System.Console.WriteLine(s);
            //  foreach (Match m in Regex.Matches(delimiterChars, pattern)) ;
            //  int value1 = Int32.Parse(m.Groups[1].Value);
            //int value2 = Int32.Parse(m.Groups[3].Value);
            {




                switch (Operation)
                    {
                        case '+':
                            return firstInt + SecondInt;
                            Console.WriteLine(Operation);

                        case '-':
                            return firstInt - SecondInt;
                        //break;
                        case '*':
                            return firstInt * SecondInt;
                        // break;
                        case '/':
                            return firstInt / SecondInt;
                        // break;
                        case '%':
                            return firstInt % SecondInt;
                        // break;
                        default:
                            answer = 0;
                            break;


                    }
                    return answer;
                }
            return answer;
        }

        private string Response()
        {
            throw new NotImplementedException();
        }

        internal static void Parse(string response)
      {
           // Console.WriteLine(response);
        }
    }
}

//1+1 pass parsing class find operan that splits numbers 