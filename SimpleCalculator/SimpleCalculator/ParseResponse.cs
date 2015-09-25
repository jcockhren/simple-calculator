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
        public int answer { get; private set; }

        public int Response(int firstInt, int SecondInt, char Operation);
         
        
            private void Calculate(string Operation)
           {
            bool isFirst = false;
            if (isFirst)
            {
                answer = firstInt;
                return;
            }
        
         
                
            switch (Operation)
            {
                case "+":
                    answer = firstInt + SecondInt;
                    break; 
                case "-":
                    answer = firstInt - SecondInt;
                    break;
                case "*":
                    answer = firstInt * SecondInt;
                    break;
                case "/":
                    answer = firstInt / SecondInt;
                    break;
                case "%":
                    answer = firstInt % SecondInt;
                    break;
                default:
                    answer = 0;
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