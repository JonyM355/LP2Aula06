using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity { get; };
        public abstract float NoiseLevel { get; };

        public abstract void Fire()
        {
            Console.WriteLine($"Ammo Capacity : {AmmoCapacity}");
            Console.WriteLine($"Noise Level   : {NoiseLevel}");
        }
    }
}