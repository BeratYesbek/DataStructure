using System.Collections;
using System.Collections.Generic;

namespace DataStructure.SingleLinkedList
{
    internal class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head;
        private SinglyLinkedListNode<T> _current;


        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            Head = head;
            _current = null;
        }

        public T Current => _current.Value;
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Head;
                return true;
            }

            _current = _current.Next;
            return _current != null;
        }

        public void Reset()
        {
            _current = null;
        }


        public void Dispose()
        {
            Head = null;
        }
    }
}