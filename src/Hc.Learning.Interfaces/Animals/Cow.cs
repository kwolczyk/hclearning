using System;

namespace Hc.Learning.Interfaces.Animals
{
    public class Cow : Animal, ISound
    {
        public Cow(string name) : base(name)
        { }

        public void MakeNoise()
        {
            Console.WriteLine($"{GetGreeting()}, Muu Muuu.");
        }
    }
}