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
        ParseResponse(int firstInt, int SecondInt, char Operation)
        {
           
        }

        internal static void Parse(string response)
        {
            //throw new NotImplementedException();
        }
    }
}
//1+1 pass parsing class find operan that slpits numbers 