using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    public class StacksUsingArrays
    {
        private int[] data;
        private int topIndex; // Index of top most element of stack 

        public StacksUsingArrays()
        {
            data = new int[4];
            topIndex = -1;
        }

        //insert element into stack 
        public void push(int ele)
        {
            if(topIndex == data.Length - 1)
            {
                //throw new DSAException();
                doubleCapacity();
            }
            data[++topIndex] = ele;

        }
        //delete element from stack
        public int pop()
        {
            if (topIndex == data.Length - 1)
            {
                //throw new DSAException();
                doubleCapacity();
            }
            int temp = data[topIndex--];
            return temp;

        }
        //find the top element of stack
        public int top()
        {
            if (topIndex == data.Length - 1)
            {
                //throw new DSAException();
                doubleCapacity();
            }

            return data[topIndex];

        }

        //double the capacity of array
        private void doubleCapacity()
        {
            int[] temp = data;
            data = new int[2 * temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                data[i] = temp[i];
            }
        }

        //find the size of stack
        public int size()
        {
            return  topIndex +1 ;
        }

        //find stack is empty or not
        public bool isEmpty()
        {
            return data.Length == -1;
        }

        public  bool balancedParanthesis(string str)
        {

            var s = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c == '(')
                {
                    s.Push(c);
                }
                else if (c == ')')
                {
                    if (s.Count == 0)
                    {
                        return false;
                    }
                    s.Pop();
                }
            }
            if (s.Count == 0)
                return true;
            else return false;

        }

    }
}
