using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    internal class BalancedTreeReturn
    {
        public int height;
        public bool isBalanced;
    }

    internal class BalancedTreePair
    {
        public bool isBalanced;
        public int minimum;
        public int maximum;
        public BalancedTreePair(int min,int max,bool isBalanced)
        {
            this.minimum = min;
            this.maximum = max;
            this.isBalanced = isBalanced;
        }

    }
}
