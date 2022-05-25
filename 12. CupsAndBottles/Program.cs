using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> cupsCapacityQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        Stack<int> bottleStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        int wastedWater = 0;

        while (cupsCapacityQueue.Any() && bottleStack.Any())
        {
            if (bottleStack.Peek() >= cupsCapacityQueue.Peek())
            {
                wastedWater += bottleStack.Pop() - cupsCapacityQueue.Dequeue();
            }
            else if (bottleStack.Peek() < cupsCapacityQueue.Peek())
            {
                int cupsCapacity = cupsCapacityQueue.Dequeue();

                while (cupsCapacity > 0 && bottleStack.Any())
                {
                    cupsCapacity -= bottleStack.Pop();
                }
                if (cupsCapacity < 0)
                {
                    wastedWater += Math.Abs(cupsCapacity);
                }
            }
        }
        if (cupsCapacityQueue.Count == 0)
        {
            Console.WriteLine($"Bottles: {string.Join(" ", bottleStack)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
        else if (bottleStack.Count == 0)
        {
            Console.WriteLine($"Cups: {string.Join(" ", cupsCapacityQueue)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}