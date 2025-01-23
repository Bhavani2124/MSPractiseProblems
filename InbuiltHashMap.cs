using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class InbuiltHashMap
    {

        public static ArrayList removeDuplicates(int[] array)
        {
            ArrayList output = new ArrayList();
            Dictionary<int,bool> dict = new Dictionary<int,bool>();
            foreach (int i in array)
            {
                if (dict.ContainsKey(i))
                {
                    continue;
                }
                output.Add(i);
                dict.Add(i, true);
            }
            return output;
        }

        public static int maxFreNumber(int[] array)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            int maxFre = 0;
            int maxFreNum = array[0];
            for (int i=0;i<array.Length;i++)
            {
                int currentEle = array[i];
                if (dict.ContainsKey(currentEle))
                {
                    dict[currentEle]++;
                }
                else
                {
                    dict[currentEle] = 1;
                }
                if (dict[currentEle] > maxFre)
                {
                    maxFre = dict[currentEle];
                    maxFreNum = currentEle;
                }
            }
            return maxFreNum;
        }

        public static void printIntersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (dict.ContainsKey(arr1[i]))
                {
                    int value = dict[arr1[i]];
                    dict[arr1[i]] = value + 1;
                }
                else
                {
                    dict[arr1[i]] = 1;
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (dict.ContainsKey(arr2[i]))
                {
                    int freq = dict[arr2[i]];
                    if(freq > 0)
                    {
                        Console.WriteLine(arr2 [i] + " ");
                        dict[arr2[i]] = freq - 1;
                    }
                }
              
            }

        }

        public static void PairSum(int[] input, int size)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            List<Tuple<int,int>> pairs = new List<Tuple<int,int>>();
            for (int i = 0;i < input.Length; i++)
            {
                for(int j = i+1; j < input.Length; j++)
                {
                    pairs.Add(Tuple.Create(input[i], input[j]));
                }
            }

            foreach(var i in pairs)
            {
                int value = i.Item1 + i.Item2;
                if (value == size)
                {
                    Console.Write(i.Item1 + "," +i.Item2);
                }

            }
        }
        public static void SMain(string[] args)
        {

            int[] arr3 = { 1, 2, 3,3};
            int[] arr1 = { 1, 4, 5, 2, 2, 3, 6, 5, 3, 2 };
            int[] arr2 = { 0,2,3,2,6,6,5,1};

            PairSum(arr3, 4);

            printIntersection(arr1,arr2);

            Dictionary<int, string> myDictionary = new Dictionary<int, string> {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" }

               };

            if (myDictionary.ContainsKey(1)) { 
                Console.WriteLine("map has key" + myDictionary[1]);
            }
            Console.WriteLine(myDictionary[2]);
            Console.WriteLine(myDictionary.Count);
            myDictionary.Remove(3);
            Console.WriteLine(myDictionary.Count);
            Dictionary<string, int> intDic = new Dictionary<string, int>();
            intDic.Add("a", 1);
            intDic.Add("b", 2);
            intDic.Add("c", 3);

                 
            ICollection<string> keys = intDic.Keys;

            int[] arr = { 1, 2, 1, 2, 3, 4, 5, 3, 4 ,3};
            Console.WriteLine("Max Frequency Number" + maxFreNumber(arr));

            ArrayList arrayList = removeDuplicates(arr);
            foreach (int i in arrayList)
            {
                Console.Write(i);
            }

        }
    }
}
