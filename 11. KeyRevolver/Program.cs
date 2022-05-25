using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        short priceOfBullet = short.Parse(Console.ReadLine());
        int sizeOfGunBarrel = int.Parse(Console.ReadLine());

        Stack<short> bulletsStack = new Stack<short>(Console.ReadLine().Split().Select(short.Parse));

        Queue<short> locksQueue = new Queue<short>(Console.ReadLine().Split().Select(short.Parse));

        int valueOfIntelligence = int.Parse(Console.ReadLine());

        int bulletCounter = 0;
        int barrelCount = 0;

        while (bulletsStack.Any() && locksQueue.Any())
        {

            if (bulletsStack.Peek() <= locksQueue.Peek())
            {
                Console.WriteLine("Bang!");
                bulletsStack.Pop();
                locksQueue.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
                bulletsStack.Pop();
            }
            barrelCount++;

            if (barrelCount == sizeOfGunBarrel && bulletsStack.Any())
            {
                barrelCount = 0;
                Console.WriteLine("Reloading!");
            }
            bulletCounter++;
        }

        int moneyEarned = valueOfIntelligence - (bulletCounter * priceOfBullet);

        if (bulletsStack.Count == 0 && locksQueue.Count > 0)
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
        }
        else if (bulletsStack.Count >= 0 && locksQueue.Count == 0)
        {
            Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
        }
    }
}
