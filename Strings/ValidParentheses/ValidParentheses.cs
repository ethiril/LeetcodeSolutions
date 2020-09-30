using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Strings.ValidParentheses
{
    class ValidParentheses
    {

        public bool IsValid(string s)
        {
            Dictionary<char, char> mappings = new Dictionary<char, char>();
            mappings.Add('(', ')');
            mappings.Add('{', '}');
            mappings.Add('[', ']');

            Stack<char> stack = new Stack<char>();
            char[] chars = s.ToCharArray();

            foreach (char c in chars)
            {
                if (mappings.ContainsKey(c))
                {
                    stack.Push(mappings[c]);
                }
                else
                {
                    if (stack.Count == 0 || c != stack.Pop())
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
