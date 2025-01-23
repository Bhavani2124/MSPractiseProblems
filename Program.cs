using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

class strings
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public static char recurringLetters()
    {
        string str = "aabcbaab";
        int n = str.Length;
        int[] frequency = new int[256];
        int maxFrequency = 0;


        for (int i = 0; i < n; i++)
        {
            frequency[str[i]] ++;
            maxFrequency = Math.Max(maxFrequency, frequency[str[i]]);
        }

        char answer = '\0';

        for (int i = 0; i < n; i++)
        {
            if (frequency[str[i]] == maxFrequency)
            {
                answer = str[i];
                break;
            }
        }
        Console.WriteLine(answer);
        return answer;
    }
    public static void stringPermutation()
    {
        string str1 = "liste";
        string str2 = "silet";
        string str3 = "";
        bool per = false;
        StringBuilder sb = new StringBuilder(str1.Length + 1);

        for (int i = 0; i < str1.Length; i++)
        {
            for (int j = 0; j < str2.Length; j++)
            {
                if (str1[i].Equals(str2[j]))
                {
                    str3 += str1[i];
                   
                }
            }
        }
        if(str3 == str1)
            per = true;
        Console.WriteLine(per);
    }
    public static void stringCompress()
    {
        string str = "sssaaabbbccbbb";
        string s = "";
        int n = str.Length;
        //	int count = 1;
        for (int i = 0; i < n; i++)
        {
            int count = 1;
            while (i < n - 1 && str[i] == str[i + 1])
            {
                count++;
                i++;
            }
            s += str[i].ToString();

            if (count > 1)
            {

                s += count;
            }

        }
        Console.WriteLine("compressed string" + ":" + s);

    }



}

class TwoDimentionalArrays
{
    public static void rowwiseTraverse()
    {
        
        int[,] arr = { { 1, 4, 2 }, { 3, 6, 8 },{ 1, 2, 3 } ,{ 1, 5 ,0} };
        int[] arr1 = new int[arr.Length]; 
        for(int i = 0;i < arr.GetLength(0);i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j]);
            }
            
        }
        Console.WriteLine();
        Console.WriteLine("rowwise" + arr.GetLength(1));
    }
    
    //find given is square matrix or not, if yes print diagonals
    public static void SquareMatrix()
    {
        int[,] arr = { { 1, 4, 6 }, { 1, 2, 3 }, { 3, 4, 5 },{ 4, 5, 6 } };
        int n= arr.GetLength(0); int m = arr.GetLength(1);
        if (n == m)
        {
            Console.WriteLine("yes");
            //left digonal
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i, i] + " ");
            }
            Console.WriteLine() ;
            //Right diagonal
            int other = n - 1;
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i,other] + " ");
                other--;
            }
        }
        else
        {
            Console.WriteLine("no");
            return;
        }

    }

    //set zeros to entire row and column in which one element is zero
    public static void SetZeros()
    {
        int[,] arr = { { 0, 2, 3 }, { 4, 0, 6 }, { 5, 6, 7 } };
        int n = arr.GetLength(0), m = arr.GetLength(1);
        //find zeroth element
        for(int i = 0;i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int number = arr[i,j];
                if(number == 0)
                {
                    n = i;
                    m = j;
                }
            }
        }
        Console.WriteLine("ith row: " + n + "jth row :" + m);
        Console.WriteLine();
        for(int i = 0;i<arr.GetLength(0);i++)
        {
            for(int j=0; j < arr.GetLength(1);j++)
            {
                if(i==n)
                    arr[i,j] = 0;
                if (j == m)
                    arr[i, j] = 0;
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine() ;
        }

    }

    //set zeros to entire row and column in which multiple element have zero
    public static void setZerosMultileElements()
    {
        int[,] matrix = { { 0, 2, 3 }, { 0, 0, 6 }, { 5, 6, 7 } };
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        bool[] rows = new bool[n];
        bool[] cols = new bool[m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i,j] == 0)
                {
                    rows[i] = true;
                    cols[j] = true;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (rows[i] || cols[j])
                {
                    matrix[i,j] = 0;
                }
                Console.Write(matrix[i, j] + " ");
            }
          
            Console.WriteLine();
        }

    }

    //print largest of column in matrix
    public static void largestColumn()
    {
        int[,] arr = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
        int n = arr.GetLength(0), m = arr.GetLength(1), largest = int.MinValue;
        
        for (int i = 0; i < m; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += arr[j,i];
            }
            if(sum > largest)
            {
                largest = sum;
            }
        }
        Console.WriteLine("sum of largest column is " + largest);
    }

    //print largest row/column in matrix
    public static void largestRoworColumn()
    {
        int[,] arr = { { 31, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
        int[][] jagged_arr = new int[4][];
        jagged_arr[0] = new int[] { 1, 2, 3, 4 };
        jagged_arr[1] = new int[] { 11, 34, 67 };
        jagged_arr[2] = new int[] { 89, 23 };
        jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

        int n = arr.GetLength(0), m = arr.GetLength(1), largest = int.MinValue, column = 0, row = 0;
        bool isrow = false, iscol = false;

        for (int i = 0; i < m; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += arr[j, i];
            }
            if (sum > largest)
            {
                largest = sum;
                column = i;
                iscol = true;
            }
        }
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                sum += arr[i, j];
            }
            if (sum > largest)
            {
                largest = sum;
                row = i;
                isrow = true;
            }
        }
        if(isrow)
            Console.WriteLine(largest + "row is " + row);
        else
            Console.WriteLine(largest + "column is " + column);
    }

    public static void spiralMatrix()
    {
        int[,] arr = {  {1,2,3,4,5,6 },
                        { 18,19,20,21,22,7 },
                        { 17,28,29,30,23,8 },
                        {16,27,26,25,24,9 },
                        {15,14,13,12,11,10 }  };
        int top = 0, bottom = arr.GetLength(0) - 1, left = 0, right = arr.GetLength(1) - 1;

        while (top <= bottom && left <= right)
        {
            //left to right
            for (int i = left; i <= right; i++)
            {
                Console.Write(arr[top, i] + " ");
            }
            top++;

            
                //top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    Console.Write(arr[i, right] + " ");
                }
            
            right--;

            //right to left
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    Console.Write(arr[bottom, i] + " ");
                }
            }
            
            bottom--;

            //bottom to top
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    Console.Write(arr[i, left] + " ");
                }
            }
            left++;
        }
    }
   
    public static void rowClomunChange()
    {
        Console.WriteLine();
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int n = arr.GetLength(0), m= arr.GetLength(1);

        for(int i = 0; i < n; i++)
        {
            for(int j = 0;j < m; j++)
            {
                Console.Write(arr[j,i] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void likeWave()
    {
        int[,] arr = { { 1, 2, 3,5 ,6}, 
                       { 4, 5, 6,11 , 5}, 
                       { 7, 8, 9 ,10,13} };
        int n = arr.GetLength(0), m = arr.GetLength(1);
       

        for (int i = 0; i < m; i++)
        {
            int col = n - 1;
            for (int j = 0; j < n; j++)
            {
                //even columns
                if (i % 2 == 0)
                    Console.Write(arr[j, i] + " ");
                else
                {
                   
                    Console.Write(arr[col, i] + " ");
                    col--;
                }
            }

        }
    }

}



class Program
{
    static void Main2Dimentional(string[] args)
    {
        strings.stringCompress();
        strings.recurringLetters();
        strings.stringPermutation();
        TwoDimentionalArrays.rowwiseTraverse();
        TwoDimentionalArrays.SquareMatrix();
        TwoDimentionalArrays.SetZeros();
        TwoDimentionalArrays.largestColumn();
        TwoDimentionalArrays.setZerosMultileElements();
        TwoDimentionalArrays.largestRoworColumn();
        TwoDimentionalArrays.spiralMatrix();
        TwoDimentionalArrays.rowClomunChange();
        TwoDimentionalArrays.likeWave();
    }
}