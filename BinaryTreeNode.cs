using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class BinaryTreeNode<T>
    {
        public T data;
        public BinaryTreeNode<T> left;
        public BinaryTreeNode<T> right;
        public BinaryTreeNode(T data)
        {
            this.data = data;
        }
    }
}
