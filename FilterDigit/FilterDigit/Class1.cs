using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit
{
    public class filtr
    {
        public static void findnimber(int number, ref List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (var h in numbers)
            {

                string str = h.ToString();
                foreach (char b in str)
                {
                    int c = (int)Char.GetNumericValue(b);
                    if (c == number)
                    {
                        result.Add(h);
                        break;
                    }
                }

            }
            numbers = result;


        }
    }
}
