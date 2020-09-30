using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Binary_Search.SqrtX
{
    class SqrtX
    {
        public int MySqrt(int x)
        {
            double result = Math.Sqrt(x);
            return Convert.ToInt32(Math.Floor(result));
        }

        public int mySqrt(int x)
        {
            long l = 1;
            long r = x;
            while (l < r)
            {
                long mid = l + (r - l) / 2;
                if (mid == x / mid)
                {
                    return (int)mid;
                }
                else if (mid > x / mid)
                {
                    r = mid - 1;
                }
                else
                    l = mid + 1;
            }
            return l > x / l ? (int)l - 1 : (int)l;
        }
    }
}
