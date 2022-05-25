using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var sequnceOfSongs = Console.ReadLine()
            .Split(", ");

        Queue<string> queue = new Queue<string>(sequnceOfSongs);

        while (queue.Count > 0)
        {
            var command = Console.ReadLine().Split();

            if (command[0] == "Play")
            {
                queue.Dequeue();
            }
            else if (command[0] == "Add")
            {
                string songToAdd = string.Join(" ", command.Skip(1));
                if (queue.Contains(songToAdd))
                {
                    Console.WriteLine($"{songToAdd} is already contained!");
                }
                else
                {
                    queue.Enqueue(songToAdd);
                }
            }
            else if (command[0] == "Show")
            {
                Console.WriteLine(string.Join(", ", queue));
            }
        }
        Console.WriteLine("No more songs!");
    }
}
