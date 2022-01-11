using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tree.BinarySearchTree
{
    public class BinarySearchTree<T> : IEnumerable<T>
        where T : IComparable
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree()
        {
        }

        public BinarySearchTree(IEnumerable<T> collection)
        {
            foreach (var value in collection)
            {
                Add(value);
            }
        }

        public void Add(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value cannot be null");
            }

            var newNode = new Node<T>(value);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var current = Root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    if (value.CompareTo(current.Value) == -1)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public Node<T> FindMin(Node<T> root)
        {
            var current = root;
            while (current.Left != null)
            {
                current = current.Left;
            }

            return current;
        }

        public Node<T> FindMax(Node<T> root)
        {
            var current = root;
            while (current.Right != null)
            {
                current = current.Right;
            }

            return current;
        }

        public Node<T> Find(Node<T> root, T value)
        {
            var current = root;
            while (true)
            {
                if (current.Value.CompareTo(value) == -1)
                {
                    current = current.Right;
                }

                if (current.Value.CompareTo(value) == 1)
                {
                    current = current.Left;
                }

                if (current.Value.CompareTo(value) == 0)
                {
                    break;
                }
            }

            return current;
        }

        public Node<T> Remove(Node<T> root, T key)
        {
            if (root == null)
            {
                return root;
            }

            else if (root.Value.CompareTo(key) < 0)
            {
                root.Left = Remove(root.Left, key);
            }

            else if (root.Value.CompareTo(key) > 0)
            {
                root.Right = Remove(root.Right, key);
            }

            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }
                else
                {
                    root.Value = FindMax(root.Right).Value;
                    root.Right = Remove(root.Right, root.Value);
                }
            }

            return root;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}