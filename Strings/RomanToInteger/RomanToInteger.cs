using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Strings.RomanToInteger
{
    class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int sum = 0;
            if (s.IndexOf("IV") != -1) { sum -= 2; }
            if (s.IndexOf("IX") != -1) { sum -= 2; }
            if (s.IndexOf("XL") != -1) { sum -= 20; }
            if (s.IndexOf("XC") != -1) { sum -= 20; }
            if (s.IndexOf("CD") != -1) { sum -= 200; }
            if (s.IndexOf("CM") != -1) { sum -= 200; }

            char[] c = s.ToCharArray();
            
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (c[i] == 'M') sum += 1000;
                if (c[i] == 'D') sum += 500;
                if (c[i] == 'C') sum += 100;
                if (c[i] == 'L') sum += 50;
                if (c[i] == 'X') sum += 10;
                if (c[i] == 'V') sum += 5;
                if (c[i] == 'I') sum += 1;

            }

            return sum;
        }
    }
}
