using System;
using System.Diagnostics;

namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    class Tree
    {
        // check if root is null. if so, init root as new node and set its value to v
        // else, if v < root.value, you should insert to the left.
        // else, (if v >= root.value), you should insert to the right
        // method expects you to return root at the end
        public Node insert(Node root, int v)
        {

            return root;
        }


        // inorder traversal is left, root, right
        // traverse left
        // check if root is null and print its value if not null
        // traverse right
        public void traverseInorder(Node root)
        {
        }

        // preorder traversal is root, left, right
        // check if root is null and print its value if not null
        // traverse left
        // traverse right
        public void traversePreorder(Node root)
        {

        }

        // postorder traversal is left, right, root
        // check if root is null and print its value if not null
        // traverse left
        // traverse right
        public void traversePostorder(Node root)
        {
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            Tree bst = new Tree();
            int SIZE = 20;
            int[] a = new int[SIZE];

            Console.WriteLine("Generating random array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                a[i] = random.Next(100);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                root = bst.insert(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

            watch = Stopwatch.StartNew();

            bst.traverseInorder(root);
            bst.traversePreorder(root);
            bst.traversePostorder(root);


            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
        }
    }
}