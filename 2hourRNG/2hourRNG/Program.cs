using System;
using Math;
using Random = Math.Random;

namespace _2hourRNG
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double i = 0; i <= 100; i++)
                Console.WriteLine(Random.Float(-10, 10));
        }
    }
}
