using System;
using DataStructure.SingleLinkedList;

namespace DataStructure.Stack
{
    internal class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();
        public int Count { get; set; }
        public void Push(T value)
        {
            list.AddFirst(value);
            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Stack is empty");
            }

            return list.Head.Value;
        }

        public T Pop()
        {
            Count--;
           return list.RemoveFirst();
        }
    }
}