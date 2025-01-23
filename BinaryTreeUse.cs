using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class BinaryTreeUse
    {
        public static BinaryTreeNode<int> takeInputLevelWise()
        {
            Console.WriteLine("Enter root data");
            int rootdata = int.Parse(Console.ReadLine());
            if (rootdata == -1)
            {
                return null;
            }
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(rootdata);
            Queue<BinaryTreeNode<int>> pendingchild = new Queue<BinaryTreeNode<int>>();
            pendingchild.Enqueue(root);
           
            while(pendingchild.Count != 0)
            {
                BinaryTreeNode<int> front = pendingchild.Dequeue();
                Console.WriteLine("Enter data for left child" + pendingchild);
                int left = int.Parse(Console.ReadLine());
                if (left != -1)
                {
                    BinaryTreeNode<int> leftChild = new BinaryTreeNode<int>(left);
                    front.left = leftChild;
                    pendingchild.Enqueue(leftChild);
                }
                Console.WriteLine("Enter data for right child" + pendingchild);
                int right = int.Parse(Console.ReadLine());
                if (right != -1)
                {
                    BinaryTreeNode<int> rightChild = new BinaryTreeNode<int>(right);
                    front.right = rightChild;
                    pendingchild.Enqueue(rightChild);
                }
            }
            return root;
        }
        public static BinaryTreeNode<int> takeInputBetter(bool isRoot, int parentData, bool isleft)
        {
            if (isRoot)
            {
                Console.WriteLine("Enter Root Data");
            }
            else
            {
                if (isleft)
                    Console.WriteLine("Enter left child for :" + parentData);
                else
                    Console.WriteLine("Enter right child for :" + parentData);
            }
            int rootdata = int.Parse(Console.ReadLine());
            if(rootdata == -1)
            {
                return null;
            }
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(rootdata);
            BinaryTreeNode<int> lefchild = takeInputBetter(false, rootdata, true);
            BinaryTreeNode<int> rightchild = takeInputBetter(false,rootdata, false);
            root.left = lefchild;
            root.right = rightchild;
            return root;


        }
        public static BinaryTreeNode<int> takeInputs()
        {
            Console.WriteLine("Enter data for tree");
            string s = Console.ReadLine();
            int rootdata = int.Parse(s);
            if (rootdata == -1)
            {
                return null;
            }
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(rootdata);
            BinaryTreeNode<int> leftchild = takeInputs();
            BinaryTreeNode<int> rightchild = takeInputs();
            root.left = leftchild;
            root.right = rightchild;
            return root;
        }
        public static void printBinaryTree(BinaryTreeNode<int> root)
        {
            if(root == null) return;
            Console.Write(root.data + ":");
            if (root.left != null)
            {
                Console.Write("L" + root.left.data + ",");
            }
            if (root.right != null)
            {
                Console.Write("R" + root.right.data + ",");
            }
            
            Console.WriteLine();
            printBinaryTree(root.left);
            printBinaryTree(root.right);
        }

        public static int largest(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return -1;
            }
            int largestLeft = largest(root.left);
            int largestright    = largest(root.right);
            return Math.Max(root.data, Math.Max(largestLeft,largestright));
        }

        public static int treeHeight(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = treeHeight(root.left);
            int rightHeight = treeHeight(root.right);
            return 1+ Math.Max(leftHeight,rightHeight);
        }

        public static int numberOfLeafs(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            return numberOfLeafs(root.left) + numberOfLeafs(root.right);
        }

        public static void printatDepth(BinaryTreeNode<int> root,int k)
        {
            if(root == null)
            {
                return;
            }
            if (k == 0)
            {
                Console.WriteLine("Print at depth" + root.data);
                return;
            }
            printatDepth(root.left,k-1);
            printatDepth(root.right,k-1);

        }

        public static BinaryTreeNode<int> RemoveLeafNodes(BinaryTreeNode<int> root)
        {
            if (root == null)
                return null;
            if(root.left == null && root.right == null)
                return null ;
            root.left = RemoveLeafNodes(root.left);
            root.right = RemoveLeafNodes(root.right);
            return root ;
        }

        public static int heightofTree(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = heightofTree(root.left);
            int rightHeight = heightofTree(root.right);

            return 1 + Math.Max(leftHeight, rightHeight);
        }

        public static bool isBalancedTree(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return true;
            }
            int leftHeight = heightofTree(root.left);
            int rightHeight = heightofTree(root.right);

            if(Math.Abs(leftHeight - rightHeight) > 1)
                return false;

            bool isleftBalanced = isBalancedTree(root.left);
            bool isrightBalanced = isBalancedTree(root.right);

            return isleftBalanced && isrightBalanced;
        }

        public static BalancedTreeReturn isBalancedBetter(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                int heightL = 0;
                bool isbalanced = true;
                BalancedTreeReturn ans = new BalancedTreeReturn();
                ans.height = heightL;
                ans.isBalanced = isbalanced;
                return ans;
            }

            BalancedTreeReturn isLeftoutput = isBalancedBetter(root.left);
            BalancedTreeReturn isRightoutput = isBalancedBetter(root.right);
            bool isBal = true;

            int height = 1 + Math.Max(isLeftoutput.height, isRightoutput.height);

            if(Math.Abs(isLeftoutput.height - isRightoutput.height) > 1)
            {
                isBal = false;
            }

            if(!isLeftoutput.isBalanced || !isRightoutput.isBalanced)
            {
                isBal = false;
            }

            BalancedTreeReturn ansFinal = new BalancedTreeReturn();
            ansFinal.height = height;
            ansFinal.isBalanced = isBal;
            return ansFinal;
        }

        public static BinaryTreeNode<int> buildTreeFromInPreOrder(int[] inOrder, int[] preOrder)
        {
            BinaryTreeNode<int>  root = buildTreeFromInPreOrderBetter(inOrder, preOrder,0,preOrder.Length-1,0,inOrder.Length-1);
            return root;
        }

        public static BinaryTreeNode<int> buildTreeFromInPreOrderBetter(int[] inOrder, int[] preOrder,int siPre,int eiPre, int siIn, int eiIn)
        {
            if(siPre > eiPre)
            {
                return null;
            }

            int rootData = preOrder[siPre];
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(rootData);

            int startIndexIn = -1;
            for(int i = siIn; i <= eiIn; i++)
            {
                if(rootData == inOrder[i])
                {
                    startIndexIn = i;
                    break;
                }
            }

            int siInLeft = siIn;
            int eiInLeft = startIndexIn - 1;
            int siInRight = startIndexIn + 1;
            int eiInRight = eiIn;
            int siPreLeft = siPre +1;
            int eiPreRight = eiPre;

            int leftSubtreeLength = eiInLeft - siInLeft + 1;

            int eiPreLeft = siPreLeft + leftSubtreeLength -1;
            int siPreRight = eiPreLeft + 1;

            BinaryTreeNode<int> left = buildTreeFromInPreOrderBetter(inOrder,preOrder,siPreLeft,eiPreLeft,siInLeft,eiInLeft);
            BinaryTreeNode<int> right = buildTreeFromInPreOrderBetter(inOrder,preOrder,siPreRight,eiPreRight,siInRight,eiInRight);
            root.left = left;
            root.right = right;

            return root;

        }

        public static bool searchBST(BinaryTreeNode<int> root,int k)
        {
            if(root == null)
            {
                return false;
            }
            if(root.data == k)
            {
                return true;
            }
            int rootData = root.data;
            if (k < rootData)
                return searchBST(root.left, k);
          
           return searchBST(root.right, k);
        }

        public static void printEleBetweenK1K2(BinaryTreeNode<int> root, int k1, int k2)
        {
            if(root == null)
            {
                return;
            }
            int rootData = root.data;
            if(k1 > rootData)
            {
                printEleBetweenK1K2(root.right, k1, k2);
            }
            else if(k2 < rootData)
            {
                printEleBetweenK1K2(root.left, k1, k2);
            }
            else
            {
                Console.Write(root.data);
                printEleBetweenK1K2(root.left, k1, k2);
                printEleBetweenK1K2(root.right, k1, k2);
            }

        }

        public static bool isBST(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return true;
            }
            int leftMin = largest(root.left);
            if(leftMin >= root.data)
            {
                return false;
            }
            int rightMax = minimum(root.right);
            if(rightMax < root.data)
            {
                return false;
            }
            bool isLeftBST = isBST(root.left);
            bool isRightBST = isBST(root.right);

            return isLeftBST && isRightBST;
        }

        public static int minimum(BinaryTreeNode<int> root)
        {
            if(root == null)
            {
                return int.MaxValue;
            }
            int leftMin = minimum(root.left);
            int rightMin = minimum(root.right);
            return Math.Min(root.data,Math.Min(leftMin,rightMin));
        }

        public static BalancedTreePair isBSTBetter(BinaryTreeNode<int> root)
        {
            if (root == null)
            {
                BalancedTreePair bp = new BalancedTreePair(int.MaxValue, int.MinValue, true);
                return bp;
            }
            BalancedTreePair isleftBST = isBSTBetter(root.left);
            BalancedTreePair isRightBST = isBSTBetter(root.right);

            int leftMin = Math.Min(root.data, Math.Min(isleftBST.minimum,isRightBST.minimum));
            int rightMax = Math.Max(root.data, Math.Max(isRightBST.maximum, isRightBST.maximum));

            bool isBST = true;

            if(isleftBST.maximum >= root.data)
            {
                isBST = false;
            }
            if(isRightBST.minimum < root.data)
            {
                isBST = false;
            }
            if (!isleftBST.isBalanced)
            {
                isBST = false;
            }
            if (!isRightBST.isBalanced)
            {
                isBST = false;
            }

            BalancedTreePair ans = new BalancedTreePair(leftMin, rightMax, isBST);
            return ans;
        }

        public static ArrayList getNodetoRootPath(BinaryTreeNode<int> root, int k)
        {
            if(root == null) return null;

            if(root.data == k)
            {
                ArrayList output = new ArrayList();
                output.Add(root.data);
                return output;
            }

            ArrayList leftOutput = getNodetoRootPath(root.left, k);
            if (leftOutput != null)
            {
                leftOutput.Add(root.data);
                return leftOutput;
            }

            ArrayList rightOutput = getNodetoRootPath(root.right, k);
            if (rightOutput != null)
            {
                rightOutput.Add(root.data);
                return rightOutput;
            }

            return null;



        }
        public static void BTSMain(string[] args)
        {
            
            int[] InOrder = { 1,2,3,4,5,6,7 };
            int[] PreOrder = { 4,2,1,3,6,5,7 };

            BinaryTreeNode<int> rotPreOrder = buildTreeFromInPreOrder(InOrder, PreOrder);
            Console.WriteLine(searchBST(rotPreOrder, 9));
            Console.WriteLine("IS BST" + isBST(rotPreOrder));

            rotPreOrder = takeInputBetter(true, 0, true);
            ArrayList path = getNodetoRootPath(rotPreOrder, 5);
            foreach (int i in path)
            {
                Console.WriteLine(i);
            }
            BinaryTreeNode<int> takeLevelWise = takeInputLevelWise();
            printBinaryTree(takeLevelWise);
            printatDepth(takeLevelWise,1);
            largest(takeLevelWise);
            treeHeight(takeLevelWise);
            numberOfLeafs(takeLevelWise);
            BinaryTreeNode<int> takeInt = takeInputBetter(true,0,true);
            printBinaryTree(takeInt);

            BinaryTreeNode<int> root = new BinaryTreeNode<int>(1);
            BinaryTreeNode<int> rootLeft = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> rootRight = new BinaryTreeNode<int>(2);
            root.left = rootLeft;
            root.right = rootRight;
            
            BinaryTreeNode<int> leftLeft = new BinaryTreeNode<int>(1);
            BinaryTreeNode<int> leftRight = new BinaryTreeNode<int>(1);
            rootLeft.left = leftLeft;
            rootLeft.right = leftRight;
            printBinaryTree(root);
            takeInputs();

            Console.WriteLine("is Balanced Tree" + isBalancedTree(root));
            Console.WriteLine("is Balanced tree better" + isBalancedBetter(root).isBalanced);

            int[] inOrder = { 4,2,5,1,3};
            int[] preOrder = { 1,2,4,5,3 };

            BinaryTreeNode<int> rootPreOrder = buildTreeFromInPreOrder(inOrder, preOrder);
        }
    }
}
