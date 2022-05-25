using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int quantityOfTheFoodForOneDay = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        Console.WriteLine(queue.Max());

        int totalOrders = queue.Count();

        for (int i = 0; i < totalOrders; i++)
        {
            if (quantityOfTheFoodForOneDay >= queue.Peek())
            {
                quantityOfTheFoodForOneDay -= queue.Peek();
                queue.Dequeue();
            }
        }

        if (queue.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        }
    }
}
