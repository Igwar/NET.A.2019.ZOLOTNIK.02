using System;

namespace FindNthRoot
{
    public static class Find
    {
       public static double FindRoot(double a, double b, double eps)
        {
            var x0 = a / b;
            var x1 = (1 / b) * ((b - 1) * x0 + a / Math.Pow(x0, (int)b - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / b) * ((b - 1) * x0 + a / Math.Pow(x0, (int)b - 1));
            }

            return x1;
        }

    }
}
