using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();

        }



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




        // bfs / dfs 
        static Node sample_tree()
        {
            Node newTree = new Node("A",
                                new Node("B",
                                       new Node("C"), new Node("D")),
                                new Node("E",
                                       new Node("F"), new Node("G",
                                                            new Node("H"), null)));
            return newTree;
        }

        static void bfs_traversal(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.Write(node.data + " ");
                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }
        }


        static void dfs_traversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.data + " ");
            dfs_traversal(node.left);
            dfs_traversal(node.right);
        }
    }





}
