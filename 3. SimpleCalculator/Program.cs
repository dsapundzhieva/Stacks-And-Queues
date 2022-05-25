using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(" ");

        Stack<string> expression = new Stack<string>(new Stack<string>(input));

        while (expression.Count > 1)
        {
            int leftNum = int.Parse(expression.Pop());
            string sign = expression.Pop();
            int rightNum = int.Parse(expression.Pop());

            if (sign == "+")
            {
                expression.Push((leftNum + rightNum).ToString());
            }
            else if (sign == "-")
            {
                expression.Push((leftNum - rightNum).ToString());
            }
        }
        Console.WriteLine(expression.Pop());
    }
}
