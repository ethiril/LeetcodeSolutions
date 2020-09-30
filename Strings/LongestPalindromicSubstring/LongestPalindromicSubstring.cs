using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class LongestPalindromicSubstring
    {
        private int lo;
        private int maxLen;

        public string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (len < 2)
                return s;

            for (int i = 0; i < len - 1; i++)
            {
                extendPalindrome(s, i, i);
                extendPalindrome(s, i, i + 1);
            }
            return s.Substring(lo, maxLen);
        }

        private void extendPalindrome(string s, int j, int k)
        {
            while (j >= 0 && k < s.Length && s[j] == s[k])
            {
                j--;
                k++;
            }
            if (maxLen < k - j - 1)
            {
                lo = j + 1;
                maxLen = k - j - 1;
            }
        }
    }
}
