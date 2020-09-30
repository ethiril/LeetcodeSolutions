using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays.BTInorderTraversal
{
    class iterative
    {
        class Node
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
