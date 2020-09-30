using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedLists.OddEvenLinkedLists
{
    class OddEven
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return null;
            };
            ListNode odd = head, even = head.next, evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;

        }

    }
}
