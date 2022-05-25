using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < n; i++)
        {
            var command = Console.ReadLine().Split();

            if (command[0] == "1")
            {
                stack.Push(sb.ToString());
                string text = command[1];
                sb.Append(text);
            }
            else if (command[0] == "2")
            {
                stack.Push(sb.ToString());
                int countRemoval = int.Parse(command[1]);
                sb.Remove(sb.Length - countRemoval, countRemoval);
            }
            else if (command[0] == "3")
            {
                int index = int.Parse(command[1]);
                var ellement = sb.ToString().ElementAt(index - 1);
                Console.WriteLine(ellement);
            }
            else if (command[0] == "4")
            {
                sb = new StringBuilder(stack.Pop());
            }
        }
    }
}
