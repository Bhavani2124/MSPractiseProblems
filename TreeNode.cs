


namespace MicrosoftProblems
{
    public class TreeNode<T>
    {
       public T data {  get; set; }
       public List<TreeNode<T>> children {  get; set; }

        public TreeNode()
        {

        }
        public TreeNode(T data)
        {
            this.data = data;
            this.children = new List<TreeNode<T>>();
        }

        public void printTree(TreeNode<T> root)
        {
            if(root == null)
            {
                return;
            }
            Console.Write(root.data + " : ");
            for (int i = 0; i < root.children.Count; i++)
            {
                printTree(root.children[i]);
            }
        }

        public int numbeofNodes(TreeNode<T> root)
        {
            int count = 1;
            for(int i = 0;i < root.children.Count; i++)
            {
                count += numbeofNodes(root.children[i]);
            }
            return count;
        }

        public int sumofNodes(TreeNode<int> root)
        {
            int sum = root.data;
            for(int i = 0; i < root.children.Count; i++)
            {
                sum  += sumofNodes(root.children[i]); 
            }
            return sum;
        }

        public  TreeNode<int> takeInput()
        {
            QueueUsingLL<TreeNode<int>> newInput = new QueueUsingLL<TreeNode<int>>();
            Console.WriteLine("Enter the root data");
            string s = Console.ReadLine();
            int rootData = int.Parse(s);
            if(rootData == -1)
            {
                return null;
            }
            TreeNode<int> parentNode = new TreeNode<int>(rootData);
            newInput.enQueue(parentNode);
           
            while (!newInput.isEmpty())
            {
                TreeNode<int> front = newInput.deQueue();
                Console.WriteLine("Enter number of childs for" + front.data);
                int numberChild = int.Parse(Console.ReadLine());
                for (int i = 0; i < numberChild; i++)
                {
                    Console.WriteLine("Enter data for " + i + "th data for" + front.data);
                    int childNode = int.Parse(Console.ReadLine());
                    TreeNode<int> node = new TreeNode<int>(childNode);
                    front.children.Add(node);
                    newInput.enQueue(node);

                }
            }
            return parentNode;
        }

        public static TreeNode<int> maxSumNode(TreeNode<int> root)
        {
            // Write your code here
            return maxSumNode(root, 0);
        }

        public static TreeNode<int> maxSumNode(TreeNode<int> root, int maxSum)
        {

            if (root.children.Count() == 0)
            {
                return null;

            }

            TreeNode<int> maxNode = null;
            int tempSum = root.data;
            for (int i = 0; i < root.children.Count(); ++i)
            {
                tempSum += root.children[i].data;
            }
            if (tempSum > maxSum)
            {
                maxSum = tempSum;
                maxNode = root;

            }

            for (int i = 0; i < root.children.Count(); ++i)
            {
                TreeNode<int> temp = maxSumNode(root.children[i], maxSum);
                if (temp == null)
                {
                    continue;
                }
                if (temp != null)
                {
                    maxNode = temp;
                }
            }
            return maxNode;
        }
    }

}
