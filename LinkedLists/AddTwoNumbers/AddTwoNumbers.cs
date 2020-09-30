using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LeetCodeProblems.LinkedLists.AddTwoNumbers
{
    class AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder();
            while (l1 != null)
            {
                s1.Append(l1.val);
                l1 = l1.next;
            }
            StringBuilder builder = new StringBuilder();
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                builder.Append(s1[i]);
            }
            string reverseds1 = builder.ToString();
            builder.Clear();
            while (l2 != null)
            {
                s2.Append(l2.val);
                l2 = l2.next;
            }
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                builder.Append(s2[i]);
            }
            string reverseds2 = builder.ToString();
            BigInteger toParse = BigInteger.Parse(reverseds1) + BigInteger.Parse(reverseds2);
            string num = toParse.ToString();
            int val = num[num.Length-1] - '0';
            ListNode result = new ListNode(val);
            for (int i = num.Length-2; i >= 0; i--)
            {
                val = num[i] - '0';
                InsertLast(result, val);                
            }
            return result;
        }
        internal ListNode GetLastNode(ListNode singlyList)
        {
            ListNode temp = singlyList;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertLast(ListNode singlyList, int new_data)
        {
            ListNode new_node = new ListNode(new_data);
            if (singlyList == null)
            {
                singlyList = new_node;
                return;
            }
            ListNode lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

    }
}
