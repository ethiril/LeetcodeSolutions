using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Binary_Search.PowX
{
    class PowX
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            if (x == 1 && n == -2147483648)
                return 1;
            if ((x == 0 || x > 1) && n == -2147483648)
                return 0;
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            return (n % 2 == 0) ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }

        public double pow(double y, double x, int n)
        {
            if (n > 0)
            {
                while (n > 1)
                {
                    y = y * x;
                    n--;
                    pow(y, x, n);
                }
                return y;
            } else
            {
                while (n < 0)
                {
                    y = y * x;
                    n++;
                    pow(y, x, n);
                }
                y = (1 / y);
                return y;
            }
        }
    }
}
