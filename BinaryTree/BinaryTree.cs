using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        private Node InsertRecursive(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data); 
            }

            if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data); 
            }
            else
            {
                root.Right = InsertRecursive(root.Right, data); 
            }

            return root;
        }

        public bool Search(int data)
        {
            return SearchRecursive(Root, data);
        }

        private bool SearchRecursive(Node root, int data)
        {
            if (root == null)
            {
                return false; 
            }

            if (root.Data == data)
            {
                return true; 
            }

            if (data < root.Data)
            {
                return SearchRecursive(root.Left, data); 
            }
            else
            {
                return SearchRecursive(root.Right, data); 
            }
        }

        public void Delete(int data)
        {
            Root = DeleteRecursive(Root, data);
        }

        private Node DeleteRecursive(Node root, int data)
        {
            if (root == null)
            {
                return root;
            }

            if (data < root.Data)
            {
                root.Left = DeleteRecursive(root.Left, data); 
            }
            else if (data > root.Data)
            {
                root.Right = DeleteRecursive(root.Right, data); 
            }
            else
            {
                // Caso 1: El nodo no tiene hijos
                if (root.Left == null && root.Right == null)
                {
                    return null;
                }

                // Caso 2: El nodo tiene un hijo
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                // Caso 3: El nodo tiene dos hijos
                Node minNode = FindMin(root.Right); 
                root.Data = minNode.Data; 
                root.Right = DeleteRecursive(root.Right, minNode.Data); 
            }

            return root;
        }

        private Node FindMin(Node root)
        {
            while (root.Left != null)
            {
                root = root.Left;
            }
            return root;
        }

        public string InOrderTraversal()
        {
            return InOrderRecursive(Root);
        }

        private string InOrderRecursive(Node root)
        {
            if (root == null)
            {
                return string.Empty;
            }

            string left = InOrderRecursive(root.Left);
            string right = InOrderRecursive(root.Right);

            return $"{left}{root.Data} {right}";
        }
    }
}
