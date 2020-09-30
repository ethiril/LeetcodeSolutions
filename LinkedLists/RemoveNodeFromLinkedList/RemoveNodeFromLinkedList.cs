using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class RemoveNodeFromLinkedList
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public void DeleteNode(ListNode node)
        {
            if (node != null)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }
}
