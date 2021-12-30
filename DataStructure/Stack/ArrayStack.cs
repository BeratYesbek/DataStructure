using System;
using System.Collections.Generic;

namespace DataStructure.Stack
{
    internal class ArrayStack<T> : IStack<T>
    {
        private readonly List<T> _list = new List<T>();
        public int Count { get; set; }

        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentException("Value is null");
            }

            _list.Add(value);
            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Stack is null");
            }

            return _list[_list.Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Stack is Empty");
            }
            var temp = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            Count--;
            return temp;
        }
    }
}