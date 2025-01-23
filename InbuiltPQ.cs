using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MicrosoftProblems
{
    internal class InbuiltPQ
    {
        public static void KLargest(int[] arr, int k)
        {
            PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
            for (int i = 0; i < k; i++)
            {
                pq.Enqueue(arr[i], i+1);
            }
            for(int i=k; i<arr.Length; i++)
            {
                if(pq.Peek() < arr[i])
                {
                    pq.Dequeue();
                    pq.Enqueue(arr[i],i+1);
                }
            }
            while(pq.Count != 0)
            {
                Console.WriteLine(pq.Dequeue());
            }
        }
        public static void MainOld(string[] args)
        {
            int[] arr = { 1, 4, 5, 6, 2, 4, 3, 1, 9 };

            PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
            for (int i = 0; i < arr.Length; i++)
            {
                pq.Enqueue(arr[i],2+i);
            }
            while (pq.Count !=0)
            {
                Console.WriteLine(pq.Peek());
                
                pq.Dequeue();
            }

            int[] arr1 = { 4, 3, 10, 9, 1, 2, 5, 6, 7, 8 };
            KLargest(arr1,3);
        }
    }
}
