using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class QueueUsingLL<T>
    {
        private Node<T> front; // Top of the stack
        private Node<T> rear;
        int count;

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
        public QueueUsingLL()
        {
            front = null;
            rear = null;
            count = 0;
        }
        public int Size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public void enQueue(T ele)
        {
            Node<T> newNode = new Node<T>(ele);
            count++;
            if(rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            

        }

        public T frontMethod()
        {
            if(front == null)
            {
                throw new DSAException();
            }
            return front.Data;
        }

        public T deQueue()
        {
            if(front == null)
            {
                throw new DSAException();
            }
            T temp = front.Data;
            front = front.Next;
            if(front == null)
            {
                rear = null;
            }
            count--;
            return temp;
        }
    }
}
