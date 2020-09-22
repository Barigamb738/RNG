using System;
using Math;
using Random = Math.Random;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much numbers should be generated?");
            double a = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What is the minimum?");
            int min = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What is the maximum?");
            int max = int.Parse(Console.ReadLine());
            Console.Clear();
            for (double i = 0; i <= a; i++)
                Console.WriteLine(Random.Int(min, max));
            Console.ReadKey();
        }
    }
}
