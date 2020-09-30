using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Stacks.EvalRPN
{
    class EvaluateRPN
    {
        public int evalRPN(string[] tokens)
        {
            int a, b;
            Stack<int> S = new Stack<int>();
            foreach (string s in tokens)
            {
                if (s.Equals("+"))
                {
                    S.Push(S.Pop() + S.Pop());
                }
                else if (s.Equals("/"))
                {
                    b = S.Pop();
                    a = S.Pop();
                    S.Push(a / b);
                }
                else if (s.Equals("*"))
                {
                    S.Push(S.Pop() * S.Pop());
                }
                else if (s.Equals("-"))
                {
                    b = S.Pop();
                    a = S.Pop();
                    S.Push(a - b);
                }
                else
                {
                    S.Push(Int32.Parse(s));
                }
            }
            return S.Pop();

        }
    }
}
