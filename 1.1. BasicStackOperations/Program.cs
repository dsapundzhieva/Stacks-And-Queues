using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine().Split();
        int push = int.Parse(command[0]);
        int pop = int.Parse(command[1]);
        int peek = int.Parse(command[2]);

        Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        if (stack.Count >= pop)
        {
            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("0");
        }
        else if (stack.Contains(peek))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(stack.Min());
        }
    }
}
