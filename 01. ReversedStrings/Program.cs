using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            stack.Push(ch);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
    }
}
