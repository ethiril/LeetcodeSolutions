using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedListPalindrome
{
    class LinkedListPalindrome
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        public static bool isPalindrome(ListNode head)
        {
            ListNode fst = head, slo = head;
            while (fst != null && fst.next != null)
            {
                fst = fst.next.next;
                slo = slo.next;
            }
            if (fst != null)
            {
                slo = slo.next;
            }
            slo = reverse(slo);
            fst = head;
            while (slo != null)
            {
                if (fst.val != slo.val)
                {
                    return false;
                }
                fst = fst.next;
                slo = slo.next;
            }
            return true;

        }

        public static ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }

    }
}
