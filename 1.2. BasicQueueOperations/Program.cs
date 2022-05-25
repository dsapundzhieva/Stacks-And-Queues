using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine().Split();
        int add = int.Parse(command[0]);
        int remove = int.Parse(command[1]);
        int check = int.Parse(command[2]);

        Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        if (queue.Count >= remove)
        {
            for (int i = 0; i < remove; i++)
            {
                queue.Dequeue();
            }
        }

        if (queue.Count == 0)
        {
            Console.WriteLine("0");
        }
        else if (queue.Contains(check))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(queue.Min());
        }
    }
}
