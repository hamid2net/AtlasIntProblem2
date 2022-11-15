using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> openParen=new Stack<char>();
            foreach(char c in s)
            {
                if(c == '(' || c== '{' || c=='[') openParen.Push(c);
                else if(c == ')' && openParen.Count>0 && openParen.Peek()=='(') openParen.Pop();
                else if (c == '}' && openParen.Count > 0 && openParen.Peek() == '{') openParen.Pop();
                else if (c == ']' && openParen.Count > 0 && openParen.Peek() == '[') openParen.Pop();
                else return false;
            }
            return openParen.Count == 0;
        }
    }
}
