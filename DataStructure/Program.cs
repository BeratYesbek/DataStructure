using System;
using DataStructure.DoublyLinkedList;
using DataStructure.SingleLinkedList;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddFirstToSinglyLinkedList();
            //AddLastToSinglyLinkedList();
            //AddAfterToSinglyLinkedList();
            //RemoveFirstSinglyLinkedList();
            //RemoveLastSinglyLinkedList();
            //RemoveBetweenSinglyLinkedList();

            // Doubly Linked List

            //AddFirstDoublyLinkedList();
            AddLastDoublyLinkedList();
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

        /*----------------------------------------------------------------------*/
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