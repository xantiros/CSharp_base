using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CSharp_base
{

    public static class DataStructure
    {
        public static void BinaryTree()
        {
            Node root = null;
            Tree bst = new Tree();
            int SIZE = 7;
            int[] a = new int[SIZE];

            Console.WriteLine("Generating random array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                a[i] = random.Next(10);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                root = bst.Insert(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

            watch = Stopwatch.StartNew();

            bst.Traverse(root);

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

        }

        public static void Lists()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(213);
            list.Add(2);
            var tst = list.Capacity; //wielkosc
            Console.WriteLine(tst);
            Console.WriteLine(list[0]);
            Console.WriteLine(list.LastOrDefault());
        }

        public static void Queue()
        {
            Queue queue = new Queue();
            queue.Enqueue("1111");
            queue.Enqueue("22");
            queue.Enqueue("3333");

            Console.WriteLine(queue.Dequeue().ToString());
        }

        public static void Stack()
        {
            Stack stack = new Stack();
            stack.Push("Hello");
            stack.Push("111");
            stack.Push(222);

            Console.WriteLine(stack.Pop().ToString());
        }
    }

    class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    class Tree
    {
        public Node Insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.value = v;
            }
            else if (v < root.value)
            {
                root.left = Insert(root.left, v);
            }
            else
            {
                root.right = Insert(root.right, v);
            }

            return root;
        }

        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.left);
            Traverse(root.right);
        }
    }

}
