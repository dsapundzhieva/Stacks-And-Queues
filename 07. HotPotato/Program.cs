using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>(Console.ReadLine().Split(" "));

        int toss = int.Parse(Console.ReadLine());
        int currentCount = 1;

        while (queue.Count > 1)
        {
            string currKid = queue.Dequeue();

            if (currentCount == toss)
            {
                Console.WriteLine($"Removed {currKid}");
                currentCount = 1;
                continue;
            }
            queue.Enqueue(currKid);
            currentCount++;
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}
