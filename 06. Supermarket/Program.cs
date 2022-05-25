﻿using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string command;
        Queue<string> queue = new Queue<string>();

        while ((command = Console.ReadLine()) != "End")
        {
            if (command == "Paid")
            {
                while (queue.Count > 0)
                {
                    Console.WriteLine(queue.Dequeue());
                }
            }
            queue.Enqueue(command);
        }

        Console.WriteLine($"{queue.Count} people remaining.");
    }
}
