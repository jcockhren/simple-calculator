using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class addition
    {
        public int AddNum(string[] input)
        {
            var leftNumber = Convert.ToInt32(input[0]);
            var rightNumber = Convert.ToInt32(input[1]);
            return leftNumber + rightNumber;
        }

        public int AddNum(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
