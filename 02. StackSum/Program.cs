using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>(input);

        string command;

        while ((command = Console.ReadLine().ToLower()) != "end")
        {
            var cmdArgs = command.Split(" ");

            if (cmdArgs[0] == "add")
            {
                int firstNum = int.Parse(cmdArgs[1]);
                int secondNum = int.Parse(cmdArgs[2]);

                stack.Push(firstNum);
                stack.Push(secondNum);
            }
            else if (cmdArgs[0] == "remove")
            {
                int number = int.Parse(cmdArgs[1]);
                if (stack.Count >= number)
                {
                    for (int i = 0; i < number; i++)
                    {
                        stack.Pop();
                    }
                }
            }
        }
        Console.WriteLine($"Sum: {stack.Sum()}");
    }
}
