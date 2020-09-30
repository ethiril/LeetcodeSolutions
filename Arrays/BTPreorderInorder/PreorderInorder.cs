using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays.BTPreorderInorder
{
    class PreorderInorder
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree(preorder, 0, inorder, inorder.Length - 1, 0);
        }

        private TreeNode BuildTree(int[] preorder, int idx, int[] inorder, int end, int start)
        {
            if (idx >= preorder.Length || start > end)
            {
                return null;
            }
            TreeNode root = new TreeNode(preorder[idx]);
            int i;
            for (i = end; i >= start; i--)
            {
                if (preorder[idx] == inorder[i])
                {
                    break;
                }
            }
            root.left = BuildTree(preorder, idx + 1, inorder, i - 1, start);
            root.right = BuildTree(preorder, idx + i - start + 1, inorder, end, i + 1);
            return root;
        }
    }
}
