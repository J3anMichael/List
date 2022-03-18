using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();

            values.Add(14);
            values.Add(4);
            values.Add(78);
            values.Add(90);

            int[] numbers = new int[] { 12, 45, 89 };
            values.AddRange(numbers);

            Console.WriteLine("A lista possui: " + values.Count + " elementos");
            Console.ReadLine();
        }
    }
}
