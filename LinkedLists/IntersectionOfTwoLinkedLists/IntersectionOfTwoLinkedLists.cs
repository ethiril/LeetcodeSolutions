using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.IntersectionOfTwoLinkedLists
{
    class IntersectionOfTwoLinkedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> res = new HashSet<ListNode>();
            ListNode temp1 = headA;
            ListNode temp2 = headB;
            while (temp1 != null)
            {
                res.Add(temp1);
                temp1 = temp1.next;
            }
            while (temp2 != null) {
                if (res.Contains(temp2))
                {
                    return temp2;
                } else
                {
                    temp2 = temp2.next;
                }
            }
            return null;
        }

    }
}
