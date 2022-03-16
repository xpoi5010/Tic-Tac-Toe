using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOXX_New
{
    public static class FactorialHelper
    {
        private static long[] buffer = new long[21]; 
        public static long GetFactorialNumber(int n)
        {
            if (n is < 0 or >= 21)
                throw new Exception();
            if(buffer[0] == 0)
            {
                buffer[0] = 1;
                for (int i = 1; i < buffer.Length; i++)
                {
                    buffer[i] = buffer[i - 1] * i;
                }
            }
            return buffer[n];
        }
    }
}
