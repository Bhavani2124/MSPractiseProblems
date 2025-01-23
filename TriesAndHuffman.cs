using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    public class TriesAndHuffman
    {
        private TriNode root;

        public TriesAndHuffman()
        {
            root = new TriNode('\0');
        }

        public void addHelper(TriNode root,string word)
        {
            if(word.Length == 0)
            {
                root.isTerminal = true;
                return;
            }
            int childIndex = word[0] - 'A';
            TriNode child = new TriNode(word[0]);
            if (child == null)
            {
                child = new TriNode(word[0]);
                root.children[childIndex] = child;
            }

            addHelper(child,word.Substring(1));
        }
        public void add(string word)
        {
            addHelper(root,word);
        }

        public void remove(string word)
        {
            removeHelper(root,word);
        }

        private void removeHelper(TriNode root,string word)
        {
            if (word.Length == 0)
            {
                root.isTerminal = false;
                return;
            }
            int childIndex = word[0] - 'A';
            TriNode child = root.children[childIndex];
            if (child == null)
            {
                return;
            }

            removeHelper(child,word.Substring(1));

        }

        private bool searchHelper(TriNode root, string word)
        {
            if (word.Length == 0)
            {
                return root.isTerminal;
            }
            int childIndex = word[0] - 'A';
            TriNode child = root.children[childIndex];
            if(child == null)
            {
                return false;
            }
            return searchHelper(child,word.Substring(1));
        }
        public bool search(string word)
        {
            return searchHelper(root,word);
        }

    }

    public class TriNode
    {
        public char data;
        public bool isTerminal;
        public TriNode[] children;

        public TriNode(char data)
        {
            this.data = data;
            this.isTerminal = false;
            this.children = new TriNode[26];
        }
    }
}
