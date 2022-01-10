using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.Tree.BinarySearchTree;

namespace DataStructure.Tree.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public List<Node<T>> List { get; set; }

        public BinaryTree()
        {
            List = new List<Node<T>>();
        }

        public List<Node<T>> InOrder(Node<T> root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                List.Add(root);
                InOrder(root.Right);
            }

            return List;
        }

        public List<Node<T>> PreOrder(Node<T> root)
        {
            if (root != null)
            {
                List.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }

            return List;
        }

        public List<Node<T>> InOrderNoneRecursive(Node<T> root)
        {
            var list = new List<Node<T>>();
            var s = new Stack<Node<T>>();
            Node<T> currentNode = root;
            bool done = false;
            while (!done)
            {
                if (currentNode != null)
                {
                    s.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (s.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = s.Pop();
                        currentNode = currentNode.Right;
                        list.Add(currentNode);
                    }
                }
            }

            return list;
        }

        public List<Node<T>> PostOrder(Node<T> root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                List.Add(root);
            }

            return List;
        }
    }
}