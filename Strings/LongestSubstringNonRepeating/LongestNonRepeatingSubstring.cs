using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Strings.LongestSubstringNonRepeating
{
    class LongestNonRepeatingSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length, ans = 0;
            int[] index = new int[128];
            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }
            return ans;
        }

        public int lengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }
    }
}
