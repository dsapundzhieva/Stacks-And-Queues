using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var expression = Console.ReadLine();
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            char ch = expression[i];

            if (ch == '(')
            {
                stack.Push(i);
            }
            else if (ch == ')')
            {
                int startIndex = stack.Pop();
                int endIndex = i;
                var subExpression = expression.Substring(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(subExpression);
            }
        }
    }
}
