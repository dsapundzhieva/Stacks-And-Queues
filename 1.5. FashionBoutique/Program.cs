using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var clothesBox = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int capacity = int.Parse(Console.ReadLine());

        Stack<int> rackStack = new Stack<int>(clothesBox);

        int countRacks = 1;
        int sum = 0;

        while (rackStack.Count > 0)
        {
            if (capacity >= (sum + rackStack.Peek()))
            {
                sum += rackStack.Pop();
            }
            else
            {
                sum = 0;
                countRacks++;
            }
        }

        Console.WriteLine(countRacks);
    }
}
