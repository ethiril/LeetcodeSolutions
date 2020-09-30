﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedLists.SortList
{
    class SortList
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public class Solution
        {
            public ListNode merge(ListNode h1, ListNode h2)
            {
                if (h1 == null)
                {
                    return h2;
                }
                if (h2 == null)
                {
                    return h1;
                }

                if (h1.val < h2.val)
                {
                    h1.next = merge(h1.next, h2);
                    return h1;
                }
                else
                {
                    h2.next = merge(h1, h2.next);
                    return h2;
                }

            }

            public ListNode SortList(ListNode head)
            {
                //bottom case
                if (head == null)
                {
                    return head;
                }
                if (head.next == null)
                {
                    return head;
                }

                //p1 move 1 step every time, p2 move 2 step every time, pre record node before p1
                ListNode p1 = head;
                ListNode p2 = head;
                ListNode pre = head;

                while (p2 != null && p2.next != null)
                {
                    pre = p1;
                    p1 = p1.next;
                    p2 = p2.next.next;
                }
                //change pre next to null, make two sub list(head to pre, p1 to p2)
                pre.next = null;

                //handle those two sub list
                ListNode h1 = SortList(head);
                ListNode h2 = SortList(p1);

                return merge(h1, h2);

            }
        }
    }
}
