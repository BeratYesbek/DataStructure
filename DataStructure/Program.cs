using System;
using System.Collections.Generic;
using DataStructure.DoublyLinkedList;
using DataStructure.Queue;
using DataStructure.SingleLinkedList;
using DataStructure.Tree.BinarySearchTree;
using DataStructure.Tree.BinaryTree;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // *********** Singly Linked List ************************

            //AddFirstToSinglyLinkedList();
            //AddLastToSinglyLinkedList();
            //AddAfterToSinglyLinkedList();
            //RemoveFirstSinglyLinkedList();
            //RemoveLastSinglyLinkedList();
            //RemoveBetweenSinglyLinkedList();

            // *********** Doubly Linked List ************************

            //AddFirstDoublyLinkedList();
            //AddLastDoublyLinkedList();
            //AddAfterDoublyLinkedList();
            //GetAllNodesDoublyLinkedList();
            //AddWithConstructor();
            //RemoveFirstDoublyLinkedList();
            //RemoveLastDoublyLinkedList();
            //RemoveBetweenDoublyLinkedList();

            // ********** Stack *****************************************

            //PushArray();
            //PushLinkedList();


            //********** Queue ******************************************
            //RemoveQueueDoublyLinkedList();
            //AddQueueDoublyLinkedList();
            //RemoveQueueArray();
            //AddQueueArray();

            //********** Tree ********************************************
            //AddTree();
            //InOrder();
            //PreOrder();
            PostOrder();
        }

        private static void PostOrder()
        {
            var binarySearchTree = new BinarySearchTree<int>(new List<int> { 23, 16, 45, 3, 22, 37, 99 });
            var list = new BinaryTree<int>().PostOrder(binarySearchTree.Root);
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }

        private static void PreOrder()
        {
            var binarySearchTree = new BinarySearchTree<int>(new List<int> { 23, 16, 45, 3, 22, 37, 99 });
            var list = new BinaryTree<int>().PreOrder(binarySearchTree.Root);
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }

        private static void InOrder()
        {
            var binarySearchTree = new BinarySearchTree<int>(new List<int> { 23, 16, 45, 3, 22, 37, 99 });
            var list = new BinaryTree<int>().InOrder(binarySearchTree.Root);
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }

        private static void AddTree()
        {
            var binarySearchTree = new BinarySearchTree<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            Console.ReadKey();
        }

        /*------------------- Queue ---------------------------------------*/
        private static void RemoveQueueDoublyLinkedList()
        {
            var queue = new Queue.Queue<int>(QueueType.LinkedList);
            queue.EnQueue(5);
            queue.EnQueue(7);
            queue.EnQueue(9);

            queue.DeQueue();
            Console.WriteLine(queue.Peek());

        }

        private static void AddQueueDoublyLinkedList()
        {
            var queue = new Queue.Queue<int>(QueueType.LinkedList);
            queue.EnQueue(5);
            queue.EnQueue(7);
            queue.EnQueue(9);

            Console.WriteLine(queue.Peek());

        }

        private static void RemoveQueueArray()
        {
            var queue = new Queue.Queue<int>();
            queue.EnQueue(5);
            queue.EnQueue(7);
            queue.EnQueue(9);

            queue.DeQueue();
            Console.WriteLine(queue.Peek());

        }

        private static void AddQueueArray()
        {
            var queue = new Queue.Queue<int>();
            queue.EnQueue(5);
            queue.EnQueue(7);
            queue.EnQueue(9);

            Console.WriteLine(queue.Peek());
        }

        /*---------------------- Stack -------------------------------- */

        private static void PushArray()
        {
            var stack = new Stack.Stack<int>();
            stack.Push(5);
            stack.Push(48);
            stack.Push(9);

            stack.Pop();
            Console.WriteLine(stack.Peek());

        }

        private static void PushLinkedList()
        {
            var stack = new Stack.Stack<int>();
            stack.Push(26);
            stack.Push(4);
            stack.Push(18);
            stack.Push(9);

            stack.Pop();

            Console.WriteLine(stack.Peek());
        }


        /*---------------------- Doubly Linked List -------------------*/
        private static void RemoveBetweenDoublyLinkedList()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(7);
            list.AddFirst(8);
            list.AddFirst(9);
            list.AddFirst(10);
            var value = list.RemoveBetween(list.Head.Next);
            Console.WriteLine(value);
        }

        private static void RemoveLastDoublyLinkedList()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(7);
            list.AddFirst(8);
            list.AddFirst(9);
            list.AddFirst(10);
            var value = list.RemoveLast();
            Console.WriteLine(value);
        }

        private static void RemoveFirstDoublyLinkedList()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(7);
            list.AddFirst(8);
            list.AddFirst(9);
            list.AddFirst(10);
            var value = list.RemoveFirst();
            Console.WriteLine(value);
        }

        private static void AddWithConstructor()
        {
            var list = new DoublyLinkedList<float>(new float[] { 5, 6, 8, 84, 96 });
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        private static void GetAllNodesDoublyLinkedList()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(10);
            list.AddFirst(8);
            list.AddLast(15);
            list.AddAfter(list.Head.Next, 18);
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        private static void AddAfterDoublyLinkedList()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(10);
            list.AddFirst(8);
            list.AddLast(15);
            list.AddAfter(list.Head.Next, 18);

            Console.ReadKey();
        }

        private static void AddLastDoublyLinkedList()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(10);
            list.AddFirst(8);
            list.AddLast(15);

            Console.ReadKey();
        }

        private static void AddFirstDoublyLinkedList()
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(10);
            list.AddFirst(8);
            list.AddFirst(15);

            Console.ReadKey();
        }

        /*---------------------- Singly Linked List -------------------*/
        private static void RemoveBetweenSinglyLinkedList()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(5);
            linkedList.AddLast(7);
            linkedList.AddFirst(2);
            linkedList.AddLast(8);
            linkedList.RemoveBetween(linkedList.Head.Next.Next);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void RemoveLastSinglyLinkedList()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(5);
            linkedList.AddLast(7);
            linkedList.AddFirst(2);
            linkedList.AddLast(8);
            linkedList.RemoveLast();
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void RemoveFirstSinglyLinkedList()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(5);
            linkedList.AddLast(8);
            linkedList.AddLast(7);
            linkedList.RemoveFirst();
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void AddFirstToSinglyLinkedList()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            Console.ReadKey();
        }

        private static void AddLastToSinglyLinkedList()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddLast(5);
            linkedList.AddLast(4);
            linkedList.AddLast(3);
            Console.ReadKey();
        }

        private static void AddAfterToSinglyLinkedList()
        {
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            linkedList.AddAfter(linkedList.Head.Next, 31);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}