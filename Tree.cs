using System;
using System.Collections.Generic;

namespace pickme
{
    public class Tree
    {
        public TreeNode head;

        public void AddNode(ListItem value)
        {
            TreeNode newNode = new TreeNode(value);
            if (head == null)
            {
                head = newNode;
                return;
            }
            insert(head, value);
        }

        private void insert(TreeNode temp, ListItem key)
        {
            if (temp == null)
            {
                head = new TreeNode(key);
                return;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(temp);

            // Do level order traversal until we find
            // an empty place.
            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp.Left == null)
                {
                    temp.Left = new TreeNode(key);
                    break;
                }
                else
                    q.Enqueue(temp.Left);

                if (temp.Right == null)
                {
                    temp.Right = new TreeNode(key);
                    break;
                }
                else
                    q.Enqueue(temp.Right);
            }
        }
        public void PrintTree(TreeNode root)
        {
            if (root == null) return;
            PrintTree(root.Left);
            Console.WriteLine(root.Value.Name);
            PrintTree(root.Right);
        }
    }



    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(ListItem value)
        {
            Value = value;
            Left = Right = null;
        }
        public ListItem Value { get; set; }
        public int NodeCount { get; set; }
    }
}