using System;
using DataStructure.SingleLinkedList;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddFirstToSinglyLinkedList();
            //AddLastToSinglyLinkedList();
            AddAfterToSinglyLinkedList();
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