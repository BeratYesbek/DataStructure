using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public interface IStack<T>
    {
        int Count { get;  set; }
        void Push(T value);
        T Peek();
        T Pop();
    }
}