using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber
{
    public static class BiggerNumber
    {
        public static int findnimber(int number, out long time)
        {
            bool flag1 = true;
            int z = 0;
            time = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            string str = number.ToString();

            for (int i = 0; str.Length - 1 > i; i++)
            {
                if ((int)Char.GetNumericValue(str[i]) == 0)
                {
                    z++;

                }
                if ((int)Char.GetNumericValue(str[i]) < ((int)Char.GetNumericValue(str[i + 1])))
                {
                    flag1 = true;
                    break;
                }
                flag1 = false;

            }
            if ((flag1 == false) || (str.Length - 1 < z)||(str.Length<=1))
                return -1;
            List<char> str1 = str.ToList();
            str1.Sort();
            List<char> str2 = new List<char>();
            bool flag = false;
            while (flag == false)
            {
                number++;
                str = number.ToString();
                str2 = str.ToList();
                str2.Sort();

                for (int i = 0; i < str.Length; i++)
                {

                    if (str1.SequenceEqual(str2))
                        flag = true;
                    else
                        flag = false;
                }

            }
            watch.Stop();
            time = watch.ElapsedMilliseconds;
            return number;


        }

    }
}
