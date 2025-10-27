using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        public override int Noise =>
            base.AmmoCapacity * 0.8;

        public GunSilencer(Gun gun) : base(gun)
        {

        }        
    }
}