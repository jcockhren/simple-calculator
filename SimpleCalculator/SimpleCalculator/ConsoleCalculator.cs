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

        public string[] Operation(string input)
        {

            string[] Operations = input.Split('+', '-', '*', '/', '%');
            return Operations;

        }
      

        public class ParsedInput
        {
            public int FirstInt;
            public int SecondInt;
            public char Operation;
            //  internal char[] operatorS;

            public char operatorSymbol { get; internal set; }


        }
    }
}
