using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SingleLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentException("Null reference");
            }

            if (Head == null)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
            }

            throw new ArgumentException("The reference has not been found in this list");
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentException("Null reference");
            }

            if (Head == null)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
            }

            throw new ArgumentException("The reference has not been found in this list");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T RemoveFirst()
        {
            if (Head == null)
                throw new Exception("Underflow!");
            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;
        }

        public T RemoveLast()
        {
            var currrent = Head;
            SinglyLinkedListNode<T> prev = null;
            while (currrent.Next != null)
            {
                prev = currrent;
                currrent = currrent.Next;
            }

            var value = prev.Next.Value;
            prev.Next = null;
            return value;
        }

        public T RemoveBetween(SinglyLinkedListNode<T> node)
        {
            var current = Head;
            SinglyLinkedListNode<T> prevNode = null;
            while (current != node)
            {
                prevNode = current;
                current = current.Next;
            }

            prevNode.Next = node.Next;
            return node.Value;
        }
    }
}