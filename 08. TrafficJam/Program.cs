using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();

        string command;

        int totalCarsPassed = 0;

        while ((command = Console.ReadLine()) != "end")
        {
            if (command == "green")
            {
                for (int i = 0; i < n; i++)
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        totalCarsPassed++;
                    }
                }
                continue;
            }
            queue.Enqueue(command);
        }
        Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
    }
}
