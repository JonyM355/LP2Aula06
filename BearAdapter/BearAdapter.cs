using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BearAdapter : IDog
    {
        private readonly IBear bear;

        public void Bark()
        {
            bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            if (bear.TryEat(objectToFetch))
            {
                Console.WriteLine("URSO!");
            }
        }

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }
    }
}