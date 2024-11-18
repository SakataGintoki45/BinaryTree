using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public int X, Y;

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
