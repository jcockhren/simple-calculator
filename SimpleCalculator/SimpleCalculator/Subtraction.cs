using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public static class Subtraction 
    {
        public static int SubtractNum(string[] input)
        {
            var leftNumber = Convert.ToInt32(input[0]);
            var rightNumber = Convert.ToInt32(input[1]);
            return leftNumber - rightNumber;
        }

    }
}
