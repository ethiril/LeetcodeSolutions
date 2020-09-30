using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays.InOrderTraversalAlternating
{
    class Alternating
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; left = null; right = null; }
        }



        public static void AlternateTraverse(TreeNode root1, TreeNode root2)
        {
            if (root1 != null && root2 != null)
            {
                AlternateTraverse(root1.left, root2.left);
                Console.WriteLine("Tree1: " + root1.val);
                Console.WriteLine("Tree2: " + root2.val);
                AlternateTraverse(root1.right, root2.right);
            }
        }

        public static void AlternatingInorder(Node root1, Node root2)
        {
            if (root1 != null && root2 != null)
            {
                AlternatingInorder(root1.left, root2.left);
                Console.WriteLine(root1.item);
                Console.WriteLine(root2.item);
                AlternatingInorder(root1.right, root2.right);
            }
        }


        public class Node
        {
            public int item;
            public Node left;
            public Node right;
            public void display()
            {
                Console.Write("[");
                Console.Write(item);
                Console.Write("]");
            }
        }


        class Tree
        {
            public Node root;
            public Tree()
            {
                root = null;
            }
            public Node ReturnRoot()
            {
                return root;
            }
            public void Insert(int id)
            {
                Node newNode = new Node();
                newNode.item = id;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (id < current.item)
                        {
                            current = current.left;
                            if (current == null)
                            {
                                parent.left = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = newNode;
                                return;
                            }
                        }
                    }
                }
            }



            public void Preorder(Node Root)
            {
                if (Root != null)
                {
                    Console.Write(Root.item + " ");
                    Preorder(Root.left);
                    Preorder(Root.right);
                }
            }
            public void Inorder(Node Root)
            {
                if (Root != null)
                {
                    Inorder(Root.left);
                    Console.Write(Root.item + " ");
                    Inorder(Root.right);
                }
            }
            public void Postorder(Node Root)
            {
                if (Root != null)
                {
                    Postorder(Root.left);
                    Postorder(Root.right);
                    Console.Write(Root.item + " ");
                }
            }
        }


    }
}
