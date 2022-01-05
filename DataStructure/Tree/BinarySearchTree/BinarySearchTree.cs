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
                        if (current==null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
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
