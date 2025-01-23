using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    public class StacksUsecs
    {
        public static void StacksMain(string[] args)
        {
            

            StacksUsingArrays stacVariable = new StacksUsingArrays();
            stacVariable.isEmpty();
            stacVariable.push(100);
            stacVariable.top();
            stacVariable.push(2);
            stacVariable.push(3);
            stacVariable.pop();
            stacVariable.size();
            stacVariable.push(12);
            stacVariable.isEmpty();
            Console.WriteLine(stacVariable.balancedParanthesis("(())"));

            var integerStack = new StacksUsingLL<int>();
            integerStack.Push(1);
            integerStack.Push(2);
            integerStack.Push(3);
            integerStack.Push(4);
            integerStack.Push(5);
            while (!integerStack.IsEmpty())
            {
                Console.WriteLine(integerStack.Pop());
            }

            var s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            Console.WriteLine(s.Count);

            var stringStack = new StacksUsingLL<string>();

            Console.WriteLine(stringStack.countBracketReversals("}{"));
            




        }


    }
}
