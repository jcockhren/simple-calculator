using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class ParseResponse
    {
        private int firstInt { get; set; }
        private int SecondInt { get; set; }
        private char Operation { get; set; }
        public int answer { get; private set; }

       public int Response(int firstInt, int SecondInt, char Operation)
        {
            Char[] delimiterChars = { '+', '-', '*', '/', '%' };
            String result = Response();
           
                
              String[] userEquation = result.Split(delimiterChars);
         foreach(char delimiterChar in delimiterChars)
            

            
                switch (Operation)
            {
                case '+':
                    return firstInt + SecondInt;
                    Console.WriteLine(firstInt + SecondInt);

                case '-':
                    return  firstInt - SecondInt;
                    //break;
                case '*':
                    return  firstInt * SecondInt;
                   // break;
                case '/':
                    return  firstInt / SecondInt;
                   // break;
                case '%':
                    return  firstInt % SecondInt;
                   // break;
                default:
                    answer = 0;
                    break;
                    

            }
            return answer;
           
        }

        private string Response()
        {
            throw new NotImplementedException();
        }

        internal static void Parse(string response)
      {
           // throw new NotImplementedException();
        }
    }
}

//1+1 pass parsing class find operan that splits numbers 