using System;

namespace Hc.Learning.Interfaces
{
    public class Zoo
    {
        private readonly ISound[] _animals;

        public Zoo(ISound[] animals)
        {
            _animals = animals;
        }

        public void MakeSomeNoise()
        {
            foreach (var animal in _animals)
                animal.MakeNoise();

            Console.ReadKey();
        }
    }
}