using System;
using System.Collections.Generic;

namespace DataStructure.Queue
{
    internal class ArrayQueue<T> : IQueue<T>
    {
        public int Count { get; set; }
        private readonly List<T> list = new List<T>();

        public void EnQueue(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            list.Add(value);
            Count++;
        }

        public T DeQueue()
        {
            if (Count == 0)
            {
                throw new Exception("Empty queue!");
            }

            var temp = list[0];
            list.RemoveAt(0);
            Count--;
            return temp;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Empty queue!");
            }

            return list[0];
        }
    }
}