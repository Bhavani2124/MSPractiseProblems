using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class BST
    {
        private BinaryTreeNode<int> root;
        private int count;

        public BST()
        {

        }
        public static bool isPresentHelper(BinaryTreeNode<int> root, int ele)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data == ele)
            {
                return true;
            }

            if (ele < root.data)
                return isPresentHelper(root.left,ele);
            else
                return isPresentHelper(root.right,ele);
        }

        public bool isPresent(int ele)
        {
            return isPresentHelper(root, ele);
        }

        public static void PrintTreeHelper(BinaryTreeNode<int> root)
        {
            if(root == null)
            {
                return ;
            }
            Console.WriteLine(root.data + " : ");
            if(root.left != null)
            {
                Console.WriteLine("L" + root.left.data + " , ");
            }
            if(root.right != null)
            {
                Console.WriteLine("R" + root.right.data + " , ");
            }

            PrintTreeHelper(root.left);
            PrintTreeHelper(root.right);

        }

        public void PrintTree()
        {
            PrintTreeHelper(root);
        }

        public int Size()
        {
            return count;
        }

        public void insert(int ele)
        {
            root = insertHelper(root, ele);
            count++;
        }

        private static BinaryTreeNode<int> insertHelper(BinaryTreeNode<int> root, int ele)
        {
            if (root == null)
            {
                BinaryTreeNode<int> newNode = new BinaryTreeNode<int>(ele);
                return newNode;
            }
            if(ele >= root.data)
            {
                root.right = insertHelper(root.right, ele);
            }
            else
            {
                root.left = insertHelper(root.left, ele);
            }
            return root;
        }
        public bool remove(int ele)
        {
            return false;
        }
    }
}
