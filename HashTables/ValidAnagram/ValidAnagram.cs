using System;
using System.Collections;
using System.Text;

namespace LeetCodeProblems.HashTables.ValidAnagram
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] counter = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                counter[s[i] - 'a']++;
                counter[t[i] - 'a']--;
            }
            foreach (int count in counter)
            {
                if (count != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
