using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();
        bool areBalanced = false;

        foreach (char ch in input)
        {
            if (ch == '{' || ch == '[' || ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == '}' || ch == ']' || ch == ')')
            {
                if (stack.Count == 0)
                {
                    areBalanced = false;
                    break;
                }
                char lastOpen = stack.Pop();
                if (lastOpen == '{' && ch == '}')
                {
                    areBalanced = true;
                }
                else if (lastOpen == '[' && ch == ']')
                {
                    areBalanced = true;
                }
                else if (lastOpen == '(' && ch == ')')
                {
                    areBalanced = true;
                }
                else
                {
                    areBalanced = false;
                    break;
                }
            }
        }

        if (areBalanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
