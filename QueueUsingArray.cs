using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class QueueUsingArray
    {
        private int[] data;
        private int frontEle;
        private int rearEle;
        private int count;

        public QueueUsingArray()
        {
            data = new int[10];
            frontEle = -1;
            rearEle = -1;
            count = 0;
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public void doubleCapacity()
        {
            int[] temp = data;
            data = new int[2 * data.Length];
            int index = 0;
            for (int i = frontEle; i < temp.Length; i++)
            {
                data[index++] = temp[i];
            }
            for(int i = 0;i < frontEle-1; i++)
            {
                data[index++] = temp[i];
            }
            frontEle = 0;
            rearEle = temp.Length - 1;
            
        }
        public void enqueue(int element)
        {
            if(count == data.Length)
            {
                //throw new DSAException();
                doubleCapacity();
            }
            if (count == 0)
            {
                frontEle++;
            }
            //rearEle++;
            //if(rearEle == data.Length)
            //{
            //    rearEle = 0;
            //}

            rearEle = (rearEle + 1)%data.Length;
            data[rearEle] = element;

            count++;
        }

        public int dequeue()
        {

            if (count == 0)
            {
                throw new DSAException();
            }
            int temp = data[frontEle];
            //frontEle++;
            //if(frontEle == data.Length)
            //{
            //    frontEle = 0;
            //}
            frontEle = (frontEle + 1) % data.Length;
            count--;
            if( count == frontEle)
            {
                frontEle = -1;
                rearEle = -1;
            }
            return temp;

        }

        public int front()
        {
            if (count == 0) {
                throw new DSAException();
            }

            return data[frontEle];

        }


    }
}
