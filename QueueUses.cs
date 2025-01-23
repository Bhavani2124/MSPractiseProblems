using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class QueueUses
    {
      
        public static void QueueMain(string[] args)
        {
            
            QueueUsingArray QA = new QueueUsingArray();
            int[] arr = { 1, 2, 3 };
            foreach (int i in arr)
            {
                QA.enqueue(i);
            }
            Console.WriteLine("Queue Size before deletion" + QA.size());
            while(!QA.isEmpty())
            {
                Console.WriteLine(QA.dequeue());
            }
            Console.WriteLine("Queue Size after deletion " + QA.size());

            
        }
    }
}
