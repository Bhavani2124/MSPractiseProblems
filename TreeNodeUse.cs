using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class TreeNodeUse
    {
        public static void TMain(string[] args)
        {
            TreeNode<int> root = new TreeNode<int>(4);
            TreeNode<int> node1 = new TreeNode<int>(3);
            TreeNode<int> node2 = new TreeNode<int>(42);
            TreeNode<int> node3 = new TreeNode<int>(41); 
            TreeNode<int> node4 = new TreeNode<int>(45);
            root.children.Add(node1);
            root.children.Add(node2);
            node2.children.Add(node3);
            node2.children.Add(node4);
            TreeNode<int> print = new TreeNode<int>();
            print.printTree(root);
            Console.WriteLine("Number of nodes" + print.numbeofNodes(root));
            Console.WriteLine("Sum of nodes" + print.sumofNodes(root));

            TreeNode<int> printDynamicInput = print.takeInput();
            print.printTree(printDynamicInput);
        }
    }
}
