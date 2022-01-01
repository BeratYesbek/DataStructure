using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public enum QueueType
    {
        Array = 0,
        LinkedList = 1
    }

    public class Queue<T>
    {
        private readonly IQueue<T> _queue;
        public int Cout => _queue.Count;

        public Queue(QueueType type = default)
        {
            if (type == QueueType.Array)
            {
                _queue = new ArrayQueue<T>();
            }
            else
            {
                _queue = new LinkedListQueue<T>();
            }
        }

        public void EnQueue(T value)
        {
            _queue.EnQueue(value);

        }

        public T DeQueue()
        {
            return _queue.DeQueue();
        }

        public T Peek()
        {
            return _queue.DeQueue();
        }
    }
}