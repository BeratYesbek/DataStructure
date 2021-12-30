using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class Stack<T>
    {
        private readonly IStack<T> _stack;
        public int Count => _stack.Count;

        public Stack(StackType type = default)
        {
            if (type == StackType.Array)
            {
                _stack = new ArrayStack<T>();
            }
            else
            {
                _stack = new LinkedListStack<T>();
            }
        }


        public T Pop()
        {
            return _stack.Pop();
        }

        public T Peek()
        {
            return _stack.Peek();
        }

        public void Push(T value)
        {
            _stack.Push(value);
        }

    }

    public enum StackType
    {
        Array = 0,
        LinkedList = 1
    }
}
