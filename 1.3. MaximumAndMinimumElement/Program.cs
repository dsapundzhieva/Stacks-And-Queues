using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            var command = Console.ReadLine().Split();
            int cmdType = int.Parse(command[0]);

            if (cmdType == 1)
            {
                stack.Push(int.Parse(command[1]));
            }
            else if (cmdType == 2)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else if (cmdType == 3)
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
            }
            else if (cmdType == 4)
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}
