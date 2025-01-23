using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{

     class PriorityQueue<T>
    {
        private List<PriorityElement<T>> heap;

        public PriorityQueue()
        {
            heap = new List<PriorityElement<T>>();
        }
        public T getMin()
        {
            if (isEmpty())
            {
                throw new NullReferenceException();
            }
            return heap[0].value;
        }
        public void insert(T Value,int priority)
        {
            PriorityElement<T> element = new PriorityElement<T>(Value,priority);
            heap.Add(element);
            int childIndex = heap.Count - 1;
            int parentIndex = (childIndex - 1) / 2;
            while (childIndex > 0) {
                if (heap[childIndex].priority < heap[parentIndex].priority)
                {
                    PriorityElement<T> temp = heap[childIndex];
                    heap[childIndex] = heap[parentIndex];
                    heap[parentIndex] = temp;
                    childIndex = parentIndex;
                    parentIndex = (childIndex - 1) / 2;
                }
                else
                {
                    return;
                }
            }
        }

       

        public T removeEle()
        {
            if (isEmpty())
            {
                throw new NullReferenceException();
            }
            PriorityElement<T> remove = heap[0];
            T ans = remove.value;
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            int parentIndex = 0;
            int leftIndex = 2 * parentIndex + 1;
            int righIndex = 2 * parentIndex + 2;

            while (leftIndex < heap.Count) {
                int minIndex = parentIndex;
                if (heap[leftIndex].priority < heap[minIndex].priority)
                {
                    minIndex = leftIndex;
                }
                if (righIndex < heap.Count &&  (heap[righIndex].priority < heap[minIndex].priority))
                {
                    minIndex = righIndex;
                }
                if(minIndex == parentIndex)
                {
                    break;
                }

                PriorityElement<T> temp = heap[minIndex];
                heap[minIndex] = heap[parentIndex];
                heap[parentIndex] = temp;
                parentIndex = minIndex;
                leftIndex = 2*parentIndex + 1;
                righIndex = 2*parentIndex + 2;
            }
            return ans;
        }

        public int size()
        {
            return heap.Count;
        }
        public bool isEmpty()
        {
            if (size() == 0)
            {
                return true;
            }
            return false;
        }

       
    }
    public class MianClass
    {
        public static void heapSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = (n / 2) - 1; i >= 0; i--)
            {
                downHeapify(arr, i, n);
            }

            //Remove elements from heap and store at last of the array in respective postions

            for(int i = n-1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = arr[0];
                arr[0] = temp;
                downHeapify(arr,0, i);
            }
        }

        public static void downHeapify(int[] arr, int i, int n)
        {
            int parenrIndex = i;
            int leftIndex = 2*parenrIndex + 1;
            int rightIndex = 2*parenrIndex + 2;

            while (leftIndex < n)
            {
                int minIndex = parenrIndex;

                if (arr[leftIndex] < arr[minIndex])
                {
                    minIndex = leftIndex;
                }

                if(rightIndex < n && arr[rightIndex] < arr[minIndex])
                {
                    minIndex = rightIndex;
                }

                if(parenrIndex == minIndex)
                {
                    return;
                }

                int temp = arr[parenrIndex];
                arr[parenrIndex] = arr[minIndex];
                arr[minIndex] = temp;
                parenrIndex = minIndex;
                leftIndex = 2* parenrIndex + 1;
                rightIndex = 2* parenrIndex + 2;
            }
        }
        public static void PQMain(string[] args)
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.insert("abc", 15);
            queue.insert("def", 13);
            queue.insert("ghi", 90);
            queue.insert("jkljh", 150);
            queue.insert("mnoyud", 130);
            while (!queue.isEmpty())
            {
                Console.WriteLine("Minimum is" + queue.getMin());
                queue.removeEle();
            }

            int[] arr = { 4, 5, 6, 3, 2, 1, 9, 10, 8 };
            heapSort(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
