using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public abstract class Mammal : Animal, IMate
    {
        public virtual bool Carnivore { get; set; } = true;
        public virtual bool Pack_Mentality { get; set; } = true;

        public bool Birthing()
        {
            return true;
        }

        public string Mating()
        {
            return "You and me baby ain't nothing but mamals";
        }

        public bool Reproducing()
        {
            return true;
        }
    }
}
