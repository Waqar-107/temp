using System;
using System.Collections.Generic;

namespace Practice_C_sharp
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class pair
    {
        public TreeNode f, s;
        public pair() { }
        public pair(TreeNode f, TreeNode s)
        {
            this.f = f;
            this.s = s;
        }
    }

    public class Solution
    {
        public pair find(TreeNode root, TreeNode parent, int val)
        {
            if (root == null) return new pair();

            if (root.val == val) return new pair(root, parent);

            if (root.val > val) return find(root.left, root, val);
            return find(root.right, root, val);
        }

        public pair findMin(TreeNode root, TreeNode parent)
        {
            if (root != null && root.left != null) return findMin(root.left, root);
            return new pair(root, parent);
        }

        public void delete(TreeNode root, TreeNode parent)
        {
            // leaf node
            if(root.left == null && root.right == null)
            {
                // update the parent node
                if (parent != null && parent.right == root)
                    parent.right = null;
                if (parent != null && root.left == root)
                    parent.left = null;
            }

            // has one child
            else if(root.left != null && root.right == null)
            {
                if (parent != null && parent.right == root)
                    parent.right = root.left;
                if (parent != null && parent.left == root)
                    parent.left = root.left;
            }

            // has one child
            else if (root.left == null && root.right != null)
            {
                if (parent != null && parent.right == root)
                    parent.right = root.right;
                if (parent != null && parent.left == root)
                    parent.left = root.right;
            }

            else
            {
                pair res = findMin(root, parent);
                root.val = res.f.val;

                delete(res.f, res.s);
            }
        }

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            pair res;
            if(root.val == key)
            {
                if (root.left == null && root.right == null)
                    return null;

                else if (root.left != null && root.right == null)
                    return root.left;

                else if (root.right != null && root.left == null)
                    return root.right;

                else
                {
                    res = findMin(root.right, root);
                    root.val = res.f.val;
                    delete(res.f, res.s);

                    return root;
                }
            }

            res = find(root, null, key);

            if (res.f == null) return root;

            delete(res.f, res.s);
            return root;
        }
    }


    public class Node
    {
        public int id, parentId;
        public string name;

        public Node() { }
        public Node(int id, int parentId, string name)
        {
            this.id = id;
            this.parentId = parentId;
            this.name = name;
        }
    }

    class Task2
    {
        public static void AddNode(string nodeName) { }
        public static void AddNode(string nodeName, Node parentNode) { }

        public static void variant_1()
        {
            List<Node> nodes = new List<Node>();

            nodes.Add(new Node(1, -1, "one"));
            nodes.Add(new Node(2, 1, "two"));
            nodes.Add(new Node(3, 1, "three"));
            nodes.Add(new Node(4, 1, "four"));
            nodes.Add(new Node(5, 2, "five"));
            nodes.Add(new Node(6, 2, "six"));
            nodes.Add(new Node(7, 3, "seven"));
            nodes.Add(new Node(8, 4, "eight"));
            nodes.Add(new Node(9, 4, "nine"));
            nodes.Add(new Node(10, 4, "ten"));

            Dictionary<int, Node> mapping = new Dictionary<int, Node>();

            foreach (Node n in nodes)
            {
                if (n.parentId == -1) AddNode(n.name);
                else AddNode(n.name, mapping[n.parentId]);

                mapping[n.id] = n;
            }
        }

        public static void variant_3()
        {
            List<Node> nodes = new List<Node>();

            nodes.Add(new Node(6, 2, "six"));
            nodes.Add(new Node(8, 4, "eight"));
            nodes.Add(new Node(3, 1, "three"));
            nodes.Add(new Node(9, 4, "nine"));
            nodes.Add(new Node(1, -1, "one"));
            nodes.Add(new Node(2, 1, "two"));
            nodes.Add(new Node(4, 1, "four"));
            nodes.Add(new Node(5, 2, "five"));
            nodes.Add(new Node(7, 3, "seven"));
            nodes.Add(new Node(10, 4, "ten"));

            Dictionary<int, List<Node>> children = new Dictionary<int, List<Node>>();

            Node root = new Node();
            foreach (Node n in nodes)
            {
                if (n.parentId == -1)
                {
                    root = n;
                    AddNode(root.name);
                }

                else
                {
                    if (!children.ContainsKey(n.parentId))
                        children[n.parentId] = new List<Node>();

                    children[n.parentId].Add(n);
                }
            }

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                Node u = q.Dequeue();

                foreach (Node e in children[u.id])
                {
                    AddNode(e.name, u);
                    q.Enqueue(e);
                }
            }
        }
        public static void Main(string[] args)
        {
            long input = Convert.ToInt64(Console.ReadLine());
            int sq = (int)Math.Sqrt(input);

            for(int i = sq; i >= 2; i--)
            {
                if(input % i == 0)
                {
                    // input / i or i prime kina
                }
            }
        }
    }
}
