using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MicrosoftProblems
{
    internal class DSAProblems
    {
        public static int binarySearch(int[] nums, int target)
        {
            int L = 0, R = nums.Length - 1;
            while (L <= R)
            {
                int mid = (L + R) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    L = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    R = mid - 1;
                }
            }
            return -1;
        }

        
            public static int binarySearchClosest(int[] nums, int left, int right, int target)
            {
                int L = left, R = right;
                int closestIndex = -1;

                while (L <= R)
                {
                    int mid = L + (R - L) / 2;

                    // If target is found at mid, return mid index  
                    if (target == nums[mid])
                    {
                        return mid;
                    }

                    // Update closestIndex if current element is closer to target  
                    if (closestIndex == -1 || Math.Abs(nums[mid] - target) < Math.Abs(nums[closestIndex] - target))
                    {
                        closestIndex = mid;
                    }

                    if (nums[mid] < target)
                    {
                        L = mid + 1;
                    }
                    else
                    {
                        R = mid - 1;
                    }
                }

                return closestIndex;
            }
        

        //bubble sort
        public static int[] bubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j=0;j< nums.Length - 1; j++)
                {
                    int swap = nums[j];
                    if (nums[j] > nums[j + 1])
                    {
                        nums[j] = nums[j + 1];
                        nums[j + 1] = swap;
                    }                                     
                }
            }
            
            return nums;
        }

        //Select sort
        public static int[] selectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[j] < arr[min])
                        min = j;
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;

            }
            return arr;
        }

        //Select sort difference between indexes
        public static int selectionSortdiff(int[] arr)
        {
            int diff = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                        
                    }
                       
                }
                diff += min - i;
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;

            }
            return diff;
        }

        //Insertion array
        public static void Insertionsort()
        {
            int[] arr = { 6,3,5,1,4,2 };
            int n = arr.Length;
            for(int i=1; i<n; i++)
            {
                int temp = arr[i], j=i-1;
                while (j >= 0 && arr[j] > temp )
                {
                    arr[j+1] = arr[j];
                    j--;

                }
                arr[j+1] = temp;
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //Merge two sorted arrays
        public static void mergerTwoArrays()
        {
            int[] arr = { 1, 3, 6, 9, 12, 23 };
            int n = arr.Length;
            int[] arr1 = { 2, 4, 6, 8 };
            int m = arr1.Length;
            int[] arr2 = new int[n+m];
            int i=0, j=0,k=0;
            while (i < n && j < m)
            {
                if (arr[i] < arr1[j])
                {
                    arr2[k] = arr[i];
                    i++; k++;
                }
                else
                {
                    arr2[k] = arr1[j];
                    j++; k++;
                }
            }
            while(i < n)
            {
                arr2[k] = arr[i];
                i++; k++;
            }
            while(j < m)
            {
                arr2[k] = arr[j];
                j++; k++;
            }

            foreach(int l in arr2)
            {
                Console.Write(l + " ");
            }
                    
        }

        //sort 0 first , 2's end
        public static void sort012(int[] arr)
        {
            int nextZero = 0;
            int nextTwo = arr.Length - 1;
            int i = 0;

            while (i <= nextTwo)
            {
                if (arr[i] == 0)
                {
                    int temp = arr[nextZero];
                    arr[nextZero] = arr[i];
                    arr[i] = temp;
                    i++;
                    nextZero++;
                }
                else if (arr[i] == 2)
                {
                    int temp = arr[nextTwo];
                    arr[nextTwo] = arr[i];
                    arr[i] = temp;
                    nextTwo--;
                }
                else
                {
                    i++;
                }
            }
            foreach (int l in arr)
            {
                Console.Write(l + " ");
            }
        }

        //smallest difference pair
        public static int smallestDifferencePair(int[] arr1,int[] arr2)
        {
            // Write your code here.
            int diff = Math.Abs(arr1[0] - arr2[0]);
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    diff = Math.Min(diff, Math.Abs(arr1[i] - arr2[j]));
                }
            }
            Console.WriteLine("Difference of pairs" + diff);
            return diff;
        }

        public static int[] countS()
        {
            // Write your code here.
            int[] a = { 4,5,6,7 };
            int[] b = { 6,7 };
           
            for (int i = 0; i < a.Length; i++)
            {
               int count =0;
                for (int j = 0; j < b.Length; j++)
                {
                    if(a[i] >= b[j])
                    {

                      count++; 
                    }
                }
                a[i] = count;
            }
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            return a;
        }

        public class Recursion
        {
            //factorial of a given number
            public static int Factorial(int n)
            {
                if(n == 0)
                {
                    return 1;
                }
                int smallOutput = Factorial(n-1);
                int output = n * smallOutput;
                
                return output;
            }
            //sum of n natural numbers
            public static int SumNaturalNumbers(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                int smallOutpot = SumNaturalNumbers(n - 1);
                int output = n + smallOutpot;
                return output;
            }

            //sum of array recursively
            public static int sum(int[] input)
            {
               
                return sum(input, 0); // Call the helper function with starting index
            }

            private static int sum(int[] input, int startIndex)
            {
                if (startIndex == input.Length)
                {
                    return 0; // Base case: if index reaches end, return 0 (sum is 0)
                }
                return input[startIndex] + sum(input, startIndex + 1); // Recursive call with incremented index
            }

            //calculate the power for given number
            public static int power(int x, int n)
            {
                if (n == 0)
                {
                    return 1;
                }
                int smallOutput = power(x, n - 1);
                int output = x * smallOutput;
                return output;

            }

            //count no of digits in a number
            public static int countDigits(int n)
            {
                // Write your code here.
                if (n / 10 == 0)
                {
                    return 1;
                }
                return 1 + countDigits(n / 10);
            }

            //print n natural numbers
            public static void naturalNumbers(int n)
            {
                if(n == 0)
                {
                    //do nothing
                    return;
                }
               naturalNumbers(n-1);
               Console.Write(n + " ");
            }

            //fibnocci series
            public static int  FibnocciSeries(int n)
            {
                if (n == 1 || n==2)
                {
                    return 1;
                }
                int series = FibnocciSeries(n - 1) + FibnocciSeries(n - 2);
                return series;
            }
            public static void print(int n)
            {
                if (n < 0)
                {
                    return;
                }
                if (n == 0)
                {
                    Console.WriteLine(n);
                    return;
                }
                print(n--);
                Console.Write(n + " ");
            }

            public static bool checkNumber(int[] input, int x, int startIndex)
            {
                if (startIndex == input.Length)
                {
                    return false;
                }
                if (input[startIndex] == x)
                {
                    return true;
                }
                return checkNumber(input, x, startIndex + 1);
            }

            public static bool checkNumber(int[] input, int x)
            {
                return checkNumber(input, x, 0);
            }

            //is Array Sorted
            public static bool isSorted(int[] input)
            {
                if (input.Length == 1)
                {
                    return true;
                }
                if (input[0] > input[1])
                {
                    return false;
                }
                int[] smallArray = new int[input.Length - 1];
                for (int i = 1; i < input.Length; i++)
                {
                    smallArray[i - 1] = input[i];
                }
                bool isSmallArraySorted = isSorted(smallArray);
                return isSmallArraySorted;
            }

            //is Array sorted in betterWay
            public static bool isSortedBetter(int[] input,int si)
            {
                if(si == input.Length - 1)
                {
                    return true;
                }
                if (input[si] > input[si + 1])
                {
                    return false;
                }
                bool isSorted = isSortedBetter(input,si + 1);
                return isSorted;

            }

            // first index occurance of a number in array 
            public static int firstIndex(int[] input, int x)
            {
                
                if(input.Length == 0)
                {
                    return -1;
                }
                if (input[0] == x)
                {
                    return 0;
                }
                int[] smallArry = new int[input.Length - 1];
                for(int i=1;i < input.Length; i++)
                {
                    smallArry[i-1] = input[i];
                }
                int fi = firstIndex(smallArry, x);
                if (fi == -1)
                
                    return -1;
                
                else
                    return fi +1 ;

            }

            // first index occurance of a number in array in better way
            public static int firstIndexBetter(int[] input, int x,int si)
            {

                if (si == input.Length)
                {
                    return -1;
                }
                if (input[si] == x)
                {
                    return si;
                }
                int k = firstIndexBetter(input,x,si+1);
                return k;
            }

            // last index occurance of a number in array in better way
            public static int LastIndexBetter(int[] input, int x, int si)
            {

                if (si == input.Length)
                {
                    return -1;
                }
               
                int k = LastIndexBetter(input, x, si + 1);
                if (k != -1)
                    return k;
                else
                {
                    if (input[si] == x)
                        return si;
                    else
                        return -1;
                }
            }

            //count zeros in a number
            public static int countZerosRec(int input)
            {
                if (input == 0)
                {
                    return 1;
                }
                if(input < 10)
                {
                    return 0;
                }
                
                int lastdigit = input % 10;
                if (lastdigit == 0)
                    return 1 + countZerosRec(input / 10);
                else
                    return 0 + countZerosRec(input / 10);

            }

            public static double findGeometricSum(int k)
            {
               
                return findGeometricSum(k, 0);
            }

            public static double findGeometricSum(int k, int si)
            {
                if (si == k)
                {
                    return 1 / Math.Pow(2, si);
                }
                return 1 / Math.Pow(2, si) + findGeometricSum(k, si + 1);
            }

            public static int sumOfDigits(int input)
            {
                // Write your code here
                //int sum = 0;
                if (input == 0)
                {
                    return input % 10;
                }
                if (input < 10)
                {
                    return input % 10;
                }
                int lastdigit =  input % 10;
               
                    return lastdigit + sumOfDigits(input / 10);
               

            }

            public static int[] allIndexes(int[] input, int x)
            {
                return allIndexes(input, x, 0);
            }

            public static int[] allIndexes(int[] input, int x, int si)
            {

                if (si == input.Length)
                {
                    return new int[0];
                }

                int[] op = allIndexes(input, x, si + 1);
                if (input[si] == x)
                {
                    int[] output = new int[op.Length + 1];
                    output[0] = si;
                    for (int i = 1; i < output.Length; i++)
                    {
                        output[i] = op[i - 1];
                    }
                    return output;
                }

                return op;

            }

           /* Working with strings */

            public static string ReplacewithChar(string str, char a,char b)
            {
                if(str.Length == 0)
                {
                    return str;
                }
                string smalloutput = ReplacewithChar(str.Substring(1),a,b);
                if (str[0] == a)
                    return b + smalloutput;
                else
                    return str[0] + smalloutput;
            }

            //remobe all x in given string
            public static string removeX(string input)
            {
                // Write your code here
                if (input.Length == 0)
                {
                    return "";
                }
                if (input[0] == 'x')
                {
                    return removeX(input.Substring(1));
                }
                return input[0] + removeX(input.Substring(1));

            }

            //Replace "pi" letters with "3.14"
            public static string ReplacePi(string input)
            {
                // Write your code here
                if (input.Length <= 0)
                {
                    return input;
                }
                if (input[0] == 'p' && input[1] == 'i')
                {
                    return "3.14" + ReplacePi(input.Substring(2));
                }
                else
                {
                    return input[0] + ReplacePi(input.Substring(1));

                }
            }

            //Remove consecutive characters from string
            public static string removeConsecutiveDuplicates(string input)
            {
                // Write your code here
                if (input.Length <= 1)
                {
                    return input;
                }
                if (input[0] == input[1])
                {
                    return  removeConsecutiveDuplicates(input.Substring(1));
                }
                else
                {
                    return input[0] + removeConsecutiveDuplicates(input.Substring(1));
                  
                }
            }

            //Binary Search Recursively
            public static int binarySearchRecursively(int[] arr, int si, int ei,int x)
            {
                if( si > ei)
                {
                    return -1;
                }
                int mi = (si + ei) / 2;
                if (arr[mi] == x)
                    return mi;
                else if (arr[mi] < x)
                    return binarySearchRecursively(arr, mi + 1, ei, x);
                else
                    return binarySearchRecursively(arr, si, mi - 1, x);
            }

            //merge sort
            public static void MergeSort(int[] arr)
            {
                
                if (arr.Length <= 1)
                {
                    return ;
                }

                int[] s1 = new int[arr.Length/2];
                int[] s2 = new int[arr.Length - s1.Length];

                for (int i = 0; i < s1.Length; i++)
                {
                    s1[i] = arr[i];
                }
                for (int j = arr.Length / 2; j < arr.Length; j++)
                {
                    s2[j-arr.Length/2] = arr[j];
                }
                MergeSort(s1);
                MergeSort(s2);
                Merge(s1, s2, arr);
               
            }

            public static int[] Merge(int[] a, int[] b , int[] c)
            {
                int i=0, j=0,k=0;
                while (i < a.Length && j < b.Length)
                {
                    if (a[i] <= b[j])
                    {
                        c[k] = a[i];
                        i++; k++;
                    }
                    else
                    {
                        c[k] = b[j];
                        j++; k++;
                    }
                }
                if (i < a.Length)
                {
                    while (i < a.Length)
                    {
                        c[k] = a[i];
                        i++; k++;
                    }
                }
                if (j<b.Length)
                {
                    while( j < b.Length)
                    {
                        c[k] = b[j];
                        j++; k++;
                    }
                }
                return c;
            }
            public static void intersection(int[] arr1, int[] arr2)
            {
                //Your code goes here
            }

            public static void Quicksort(int[] arr,int si,int ei)
            {
                if (si >= ei)
                {
                    return;
                }
                int pi = PartitionIndex(arr,si,ei);
                Quicksort(arr,si,pi-1);
                Quicksort(arr,pi+1,ei);
            }

            public static int PartitionIndex(int[] arr,int si,int ei)
            {
                int pivot = arr[si];
                int smallcount = 0;
                for (int k = si; k <= ei; k++)
                {
                    if (arr[k] < pivot)
                    {
                        smallcount++;
                    }
                }
                int temp = arr[si + smallcount];
                arr[si + smallcount] = pivot;
                arr[si] = temp;

                int i = si, j = ei;
                while (i < j)
                {
                    if (arr[i] < pivot)
                    {
                        i++;
                    }
                    else if (arr[j] >= pivot)
                    {
                        j--;
                    }
                    else
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        i++; j--;
                    }
                }

                return si + smallcount;

            }

            //Tower of Hanoi
            public static void towerOfHanoi(int n, char s, char h, char d)
            {
                // Write your code here
                if (n == 0)
                {
                    return;
                }
                towerOfHanoi(n - 1, s, d, h);
                Console.WriteLine("Move" +n+ "th disk from " +s + " " + d);
                towerOfHanoi(n - 1, h, s, d);

            }

            public static int binarySearch(int[] input, int element, int si, int ei)
            {
                // Write your code here
                int n = input.Length;

                if (si > ei)
                    return -1;
                int mid = (si + ei) / 2;
                if (input[mid] == element)
                    return mid;
                else if (input[mid] < element)
                    return binarySearch(input, element, mid +1, ei);
                else
                    return binarySearch(input, element, si, mid-1);
            }
            public static int binarySearch(int[] input, int element)
            {
                return binarySearch(input, element, 0, input.Length - 1);
            }
            public static bool isPalindromeString(string str, int si, int ei)
            {
                // Write your code here.
                
                if(si > ei)
                {
                    return true;
                }
                if (str[si] != str[ei])
                {
                    return false;
                }
                 return isPalindromeString(str,si+1,ei-1);
            }
            public static bool isPalindromeString(string str)
            {
                return isPalindromeString(str, 0,str.Length-1);
            }
            public static string addStars(string s)
            {
                // Write your code here
                int n = s.Length;
                if (n <= 1) 
                {
                    return s;
                }
                string small = addStars(s.Substring(1));
                if (s[0] == s[1])
                    return s[0] + "*" + small;
                else return s[0] + small;
            }

            public static bool checkAB(string s, int idx)
            {
                if (idx >= s.Length)
                {
                    return true;
                }
                if (s[idx] != 'a')
                {
                    return false;
                }
                if (idx + 1 < s.Length && idx + 2 < s.Length)
                {
                    if (s[idx + 1] == 'b' && s[idx + 2] == 'b')
                    {
                        return checkAB(s, idx + 3);
                    }
                }
                return checkAB(s, idx + 1);
            }

            public static bool checkAB(string s)
            {
                if (s[0] != 'a')
                {
                    return false;
                }
                return checkAB(s, 0);
            }

            public static void CalcSubset(List<int> A,
                           List<List<int>> res,
                           List<int> subset, int index)
            {
                // Add the current subset to the result list
                res.Add(new List<int>(subset));

                // Generate subsets by recursively including and
                // excluding elements
                for (int i = index; i < A.Count; i++)
                {
                    // Include the current element in the subset
                    subset.Add(A[i]);

                    // Recursively generate subsets with the current
                    // element included
                    CalcSubset(A, res, subset, i + 1);

                    // Exclude the current element from the subset
                    // (backtracking)
                    subset.RemoveAt(subset.Count - 1);
                }
            }

            public static List<List<int>> Subsets(List<int> A)
            {
                List<int> subset = new List<int>();
                List<List<int>> res = new List<List<int>>();
                int index = 0;
                CalcSubset(A, res, subset, index);
                return res;
            }

            //String Permutations
            public static string[] permutationOfString(string input)
            {
                // Write your code here
                int n = input.Length; string substring = "";
                List<string> result = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    string firstChar = input[i].ToString();
                    substring = input.Replace(firstChar, "");
                    string resultstring = firstChar + substring;

                    result.Add( resultstring );
                }
                return result.ToArray();
            }

            public static int arrayEquilibriumIndex(int[] arr)
            {
                //Your code goes here
                int n = arr.Length;
                int totalsum =0,leftsum = 0,i=0;
                while(i < n)
                {
                    totalsum += arr[i];
                    i++;
                }
                int index = 0;
                while (index < n)
                {
                    int rightsum = totalsum -leftsum - arr[index];
                    if(leftsum == rightsum)
                        return index;
                    leftsum = leftsum + arr[index];
                    index++;
                }
                return -1;
            }

            public static int findUnique(int[] arr)
            {
                //Your code goes here
                 Array.Sort(arr);
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i+1 < arr.Length && arr[i] == arr[i + 1])
                    {
                        i = i + 1;
                    }
                    else
                        return arr[i];
                }
                return arr[0];
            }

            public static int TripletSum(int[] arr, int num)
            {
                Array.Sort(arr);
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        int sum = arr[i] + arr[j] + arr[j + 1];
                       
                        if (sum == num)
                        {
                            count = count + 1;

                        }
                    }
                }
                return count;
            }

            public static bool checkSequence(string a, string b)
            {
                /* Your class should be named Solution
                 * Don't write main().
                 * Don't read input, it is passed as function argument.
                 * Return output and don't print it.
                 * Taking input and printing output is handled automatically.
                 */
                if (b.Length == 0)
                {
                    return true;
                }
                if (a.Length == 0)
                {
                    return false;
                }
                if (a[0] == b[0])
                {
                    a = a.Substring(1);
                    b = b.Substring(1);
                }
                else
                {
                    a = a.Substring(1);
                }

                bool ans = checkSequence(a, b);

                return ans;

            }
            public static bool splitArray(int[] a)
            {
                /* Your class should be named solution
                * Don't write main().
                * Don't read input, it is passed as function argument.
                * Return output and don't print it.
                * Taking input and printing output is handled automatically.
                */
                return splitArray(a, 0, 0, 0);

            }
            private static bool splitArray(int[] input, int si, int lsum, int rsum)
            {
                if (input.Length == si)
                {
                    return lsum == rsum;
                }
                if (input[si] % 3 == 0)
                {
                    lsum += input[si];
                }
                else if (input[si] % 5 == 0)
                {
                    rsum += input[si];
                }
                else
                {
                    return splitArray(input, si + 1, lsum + input[si], rsum) ||
                            splitArray(input, si + 1, lsum, rsum + input[si]);
                }

                return splitArray(input, si + 1, lsum, rsum);
            }

            public static int maxProfit(int[] a)
            {
                int ans = int.MinValue;
                int n = a.Length;
                for (int i = 0; i < n; i++)
                {
                    ans = Math.Max(ans, a[i] * (n - i));
                }
                return ans;
            }

        }



        public static void DSAMain(string[] args)
        {
            Console.WriteLine("codesequesnce  " +Recursion.checkSequence("abchjsgsuohhdhyrikkknddg", "coding"));
            int[] splitArr = { 1, 4, 3 };
            Recursion.splitArray(splitArr);
            Console.WriteLine(splitArr);
            int[] uniquearr = { 1, 6, 5,9,5, 6, 1 };
            Console.WriteLine(Recursion.findUnique(uniquearr));
            string str = "00011234";
            int s = Convert.ToInt32(str);
            Console.WriteLine("conevr to int" + s);
            string pal = "abcd3dcba";
            Console.WriteLine("String Palindrome" + Recursion.isPalindromeString(pal));
            int[] merger = { 2, 13, 4, 1, 3, 6, 28 };
            Recursion.MergeSort(merger);
            Console.WriteLine("Merger Sort Recursively");
            foreach (int i in merger)
            {
                Console.Write(i + " ");
            }

            int[] input = { 3, 8, 9 };
            bool flag = Recursion.checkNumber(input,8);
            Console.WriteLine(flag);
            countS();
            Console.WriteLine("Hello DSA");
            int[] arr = { 2, 6, 11, 26, 39, 45, 47, 56, 68, 93 };
            int m = arr.Length - 1;
            binarySearchClosest(arr, 0, m, 56);
            int[] sortArray = { 3, 93, 89, 11, 5, 75, 46, 1 };
            int[] sortArray1 = { 3, 93, 89, 11, 5, 75, 46, 1 };
            int[] diffIndices = { 3, 2, 11, 5, 1 };

            int solution = binarySearch(arr, 56);
            Console.WriteLine(solution);
            Console.WriteLine();
            bubbleSort(sortArray);
            int[] selectsort = selectionSort(sortArray1);
            Console.Write("Selection Sort: ");
            foreach (int i in selectsort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int diffSelection = selectionSortdiff(diffIndices);
            Console.WriteLine(diffSelection);
            Console.WriteLine();
            Insertionsort();
            Console.WriteLine("Merger Two sorted arrays");
            mergerTwoArrays();
            int[] zeroArray = { 1, 0, 2, 0, 1, 0, 0, 1, 2, 0 };
            sort012(zeroArray);
            int[] arr1 = { 12,7,5};
            int[] arr2 = {  4,4,6 };
            smallestDifferencePair(arr1,arr2);
            Console.WriteLine();
            int n = Recursion.Factorial(7);
            Console.WriteLine(n);
            int sum = Recursion.SumNaturalNumbers(10);
                Console.WriteLine(sum);
           int r=  Recursion.sum(arr1);
            Console.WriteLine("Sum of Array" + r);
            int powerofX = Recursion.power(2, 5);
            Console.WriteLine(powerofX);
            Console.WriteLine(Recursion.countDigits(12345));
            Recursion.naturalNumbers(10);
            //int fib = Recursion.FibnocciSeries(2);
            // Console.WriteLine("Fibnocci series" + fib);
            // Recursion.print(3);
            Console.WriteLine("isSorted" + Recursion.isSorted(sortArray));
            Console.WriteLine("isSortedBetter" + Recursion.isSortedBetter(sortArray,0));
            int[] firstIndi = { 3, 2, 3, 3 };
            Console.WriteLine("First Occurance " + Recursion.firstIndex(firstIndi, 3));
            Console.WriteLine("Last Occurance " + Recursion.LastIndexBetter(firstIndi, 3,0));
            Console.WriteLine("countZero " + Recursion.countZerosRec(10001));
            Console.WriteLine("Geometric Sum " + Recursion.findGeometricSum(3));
            Console.WriteLine("Sum of digits recursively" + Recursion.sumOfDigits(6235));

            int[] output = Recursion.allIndexes(firstIndi,3);
            foreach(int i in output)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Replace with Character " + Recursion.ReplacewithChar("abcbdbcb", 'b', 'x'));
            Console.WriteLine("Remove x from string " + Recursion.removeX("pxxp"));
            Console.WriteLine("Replace pi with 3.14  " + Recursion.ReplacePi("pippijn"));
            Console.WriteLine("Remove consecutive duplicates " + Recursion.removeConsecutiveDuplicates("aabbccddd"));
            int[] bsr = { 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Binary Search Recursively " + " " + Recursion.binarySearchRecursively(bsr, 0, 6, 5));
            int[] quicsort = { 10, 4, 5, 8, 9, 6, 12, 11, 7 };
            Recursion.Quicksort(quicsort, 0, quicsort.Length - 1);
            Console.WriteLine("Quick sort");
            foreach(int i in quicsort)
            {
                Console.Write(i + " ");
            }
            Recursion.towerOfHanoi(2, 's', 'h', 'd');
            int[] bsArray = { 2, 3, 4, 5, 6, 8 };
            Console.WriteLine("BS element" + Recursion.binarySearch(bsArray, 5));
            string stars = "hello";
            Console.WriteLine("Starts adding" + Recursion.addStars(stars));
            string check = "ababb";
            Console.WriteLine(Recursion.checkAB(check));
            List<int> array = new List<int> { 1, 2, 3 };
            List<List<int>> res = Recursion.Subsets(array);

            // Print the generated subsets
            foreach (List<int> subset in res)
            {
                int sumsub = 0;
                foreach(int i in subset)
                {
                    sumsub += i;
                }
                Console.WriteLine(sumsub);
                Console.WriteLine(string.Join(" ", subset) + "Subsets");
            }

            string per = "adg";
            string[] resultper = Recursion.permutationOfString(per);
            foreach(string super in resultper)
            {
                Console.WriteLine(super + " ");
            }
            int[] arrayEqui = { 1, 3, 4, 2, 2, 5, 4, 1 };
            Console.WriteLine("Array Equi" + Recursion.arrayEquilibriumIndex(arrayEqui));
        }
    }
    
}
