using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MicrosoftProblems
{
    //public class StacksUsingLL<T>
    //{
    //    private Node<T> head;
    //    private int sizeofStack;

    //    public StacksUsingLL()
    //    {
    //        head = null;
    //        sizeofStack = 0;
    //    }
    //    //size of stack
    //    public int size()
    //    {
    //        return sizeofStack;
    //    }

    //    //is stack empty or not
    //    public bool isEmpty()
    //    {
    //        if (sizeofStack == 0) return true;
    //        else return false;

    //    }

    //    //insert data into Stack
    //    public void Push(T ele)
    //    {
    //        Node<T> newNode = new Node<T>(ele);
    //        newNode.next = head;
    //        head = newNode;
    //        sizeofStack++;
    //    }

    //    //delete data into Stack
    //    public T pop()
    //    {
    //        if(head == null)
    //        {
    //            throw new DSAException();
    //        }
    //        return head.data;

    //    }

    //    //read top element from Stack
    //    public T top()
    //    {
    //        if (head == null)
    //        {
    //            throw new DSAException();
    //        }
    //        T temp = head.data;
    //        head = head.next;
    //        sizeofStack--;
    //        return temp;

    //    }



    //}

    //public class Node<T>
    //{
    //    public T data;
    //    public Node<T> next;

    //    public Node(T data){
    //         this.data = data;
    //     }


    //}



    public class StacksUsingLL<T>
    {
        private Node<T> top; // Top of the stack

        // Inner Node class
        private class Node<U>
        {
            public U Data { get; set; }
            public Node<U> Next { get; set; }

            public Node(U data)
            {
                Data = data;
                Next = null;
            }
        }
        
        public void Push(T data)
        {
            var newNode = new Node<T>(data);
            newNode.Next = top;
            top = newNode;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T data = top.Data;
            top = top.Next;
            return data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return top.Data;
        }

        public  int countBracketReversals(string input)
        {
            //Your code goes here


            var ch = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{')
                {
                    ch.Push(input[i]);
                }
                else if (input[i] == '}')
                {
                    if (ch.Count != 0)
                    {
                        ch.Pop();
                    }
                    else
                    {
                        ch.Push(input[i]);
                    }
                }
            }
            int count = 0;
            if (ch.Count != 0)
            {
                char c1 = ch.Pop();
                char c2 = ch.Pop();
                if (c1 == c2)
                {
                    count += 2;
                }
                else
                {
                    count += 1;
                }
            }

            return count;

        }
    }
}

