using System;

namespace Hc.Learning.Interfaces.Animals
{
    public class Sheep : Animal, ISound
    {
        public Sheep(string name) : base(name)
        { }

        public void MakeNoise()
        {
            Console.WriteLine($"{GetGreeting()}, Bee Bee Bee.");
        }
    }
}