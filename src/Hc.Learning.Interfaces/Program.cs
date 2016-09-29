﻿using System.Linq;

namespace Hc.Learning.Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var animalsProvider = new AnimalsProvider();
            var animals = animalsProvider.GenerateAnimals();
            var zoo = new Zoo(animals.ToArray());
            zoo.MakeSomeNoise();
        }
    }
}