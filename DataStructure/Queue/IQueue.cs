using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T Peek();
    }

}
