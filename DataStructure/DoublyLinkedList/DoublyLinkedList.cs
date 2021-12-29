using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DoublyLinkedList
{
    internal class DoublyLinkedList<T> : IEnumerable
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public DoublyLinkedList()
        {
        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddFirst(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head != null)
            {
                Head.Prev = newNode;
            }

            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;

            if (Tail == null)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (Head != null)
            {
                Tail.Next = newNode;
                newNode.Prev = newNode;
                Tail = newNode;
            }
            else
            {
                newNode = Head;
                newNode = Tail;
            }
        }

        public void AddAfter(DoublyLinkedListNode<T> node, T value)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value);
            if (node == null)
            {
                throw new ArgumentException("Node cannot be null");
            }

            if (node == Head && node == Tail)
            {
                node.Next = newNode;
                node.Prev = null;

                newNode.Prev = node;
                newNode.Next = null;

                Head = node;
                Tail = newNode;
                return;
            }
            else if (node != Tail)
            {
                newNode.Prev = node;
                newNode.Next = node.Next;
                node.Next.Prev = newNode;
                node.Next = newNode;
            }
            else
            {
                newNode.Prev = node;
                newNode.Next = null;
                node.Next = newNode;
                Tail = newNode;
            }
        }

        public T RemoveFirst()
        {
            if (Head == null)
            {
                throw new Exception("Head is null");
            }

            var temp = Head.Value;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            return temp;
        }

        public T RemoveLast()
        {
            if (Head == null)
            {
                throw new ArgumentException("Head is null");
            }

            var temp = Tail.Value;
            if (Tail != Head)
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            else
            {
                Head = null;
                Tail = null;
            }

            return temp;
        }

        public T RemoveBetween(DoublyLinkedListNode<T> node)
        {
            var current = Head;
            if (current == null || node == null)
            {
                throw new ArgumentException("Head or node is null");
            }

            if (Head == Tail)
            {
                Head = null;
                Tail = null;

                return current.Value;
            }

            while (current != node)
            {
                current = current.Next;
            }

            current.Prev = node.Next;
            current.Next.Prev = node.Prev;
            return current.Value;
        }

        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }

            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}