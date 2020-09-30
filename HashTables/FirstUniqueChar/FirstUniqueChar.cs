using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.HashTables.FirstUniqueChar
{
    class FirstUniqueChar
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            int n = s.Length;
            // build hash map : character and how often it appears
            for (int i = 0; i < n; i++)
            {
                char c = s[i];
                count[c] = count.GetValueOrDefault(c, 0) + 1;
            }

            // find the index
            for (int i = 0; i < n; i++)
            {
                if (count[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}
