using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parametric_Function
{
    class Node
    {
        public Node left;
        public Node right;
        public object key;
        public Node(object key, Node left, Node right)
        {
            this.key = key;
            this.left = left;
            this.right = right;
        }
    }
}
