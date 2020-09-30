using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedLists.LinkedListCycle
{

 
    class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (head != null)
            {
                if (set.Contains(head))
                {
                    return true;
                } else
                {
                    set.Add(head);
                }
                head = head.next;
            }
            return false;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }
    }
}
