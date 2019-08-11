using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumber
{
    public class InsertNum
    {
        public static int Insert(int num1, int num2, int i, int j)
        {
            if (i < 0 || j < 0 || i > 31 || j > 31)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (i > j)
            {
                throw new ArgumentException();
            }

            int mask = ((2 << (j - i)) - 1) << i;
            return (num1 & ~mask) | ((num2 << i) & mask);
        }
    }
}
