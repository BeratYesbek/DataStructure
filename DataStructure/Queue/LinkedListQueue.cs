using System;
using DataStructure.DoublyLinkedList;
namespace DataStructure.Queue
{
    internal class LinkedListQueue<T> : IQueue<T>
    {
        public int Count { get; private set; }
        private readonly DoublyLinkedList<T> list = new DoublyLinkedList<T>();
        public void EnQueue(T value)
        {
            if (value == null)
            {
                throw new Exception("Empty value!");
            }
            list.AddLast(value);
            Count++;
        }

        public T DeQueue()
        {
            if (Count == 0)
            {
                throw new Exception("Empty queue!");
            }

            var temp = list.RemoveFirst();
            Count--;
            return temp;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Empty queue!");
            }

            return list.Head.Value;
        }
    }
}