﻿using System;

namespace GunDecorations
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Gun gun = new MachineGun();
            gun = new GunClip(gun);

            gun.Fire();
        }
    }
}
