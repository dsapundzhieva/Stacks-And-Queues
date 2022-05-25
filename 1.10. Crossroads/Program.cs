using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        int durationGreenLightInSeconds = int.Parse(Console.ReadLine());

        int durationOfFreeWindowInSeconds = int.Parse(Console.ReadLine());

        string command;

        Queue<string> carsQueue = new Queue<string>();
        int counter = 0;
        bool isCrashed = false;

        while ((command = Console.ReadLine()) != "END")
        {
            int copyDurationGreenLightInSeconds = durationGreenLightInSeconds;
            int copyDurationOfFreeWindowInSeconds = durationOfFreeWindowInSeconds;

            if (command == "green")
            {
                while (copyDurationGreenLightInSeconds > 0 && carsQueue.Any())
                {
                    string currentCar = carsQueue.Dequeue();
                    copyDurationGreenLightInSeconds -= currentCar.Length;

                    if (copyDurationGreenLightInSeconds >= 0)
                    {
                        counter++;
                    }
                    else
                    {
                        copyDurationOfFreeWindowInSeconds += copyDurationGreenLightInSeconds;

                        if (copyDurationOfFreeWindowInSeconds < 0)
                        {
                            Console.WriteLine($"A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[currentCar.Length + copyDurationOfFreeWindowInSeconds]}.");
                            isCrashed = true;
                            return;
                        }
                        counter++;
                    }
                }

            }
            else
            {
                carsQueue.Enqueue(command);
            }
        }
        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{counter} total cars passed the crossroads.");

    }
}
