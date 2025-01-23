using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    public class PriorityElement<T>
    {
        public T value;
        public int priority;
        public PriorityElement(T value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }
    }
}
