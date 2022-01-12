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
        public Node<T> Root { get; set; }
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

        public List<Node<T>> PreOrderNoneRecursive(Node<T> root)
        {
            var list = new List<Node<T>>();
            var stack = new Stack<Node<T>>();

            stack.Push(root);
            while (stack.Count != 0)
            {
                var temp = stack.Pop();
                list.Add(temp);
                if (temp.Right != null)
                {
                    stack.Push(temp.Right);
                }

                if (temp.Left != null)
                {
                    stack.Push(temp.Left);
                }
            }

            return list;
        }

        public List<Node<T>> LevelOrderNoneRecursive(Node<T> root)
        {
            var list = new List<Node<T>>();
            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                list.Add(temp);
                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }

            return list;
        }

        public static int MaxDepth(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            return (leftDepth > rightDepth) ? leftDepth + 1 : rightDepth + 1;
        }

        public Node<T> DeepestNode(Node<T> root)
        {
            Node<T> temp = null;
            if (root == null)
            {
                throw new Exception("Empty tree!");
            }

            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                temp = queue.Dequeue();
                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }

            return temp;
        }


    }
}