using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public abstract class Reptile : Animal, IHunt
    {
        public bool Dry_Skin { get; set; }
        public virtual int Num_Spots { get; set; }

        public bool FoundPrey()
        {
            return true;
        }

        public string Hunting()
        {
            return "Where are you my preciousss";
        }

        public virtual bool Lays_Eggs()
        {
            return true;
        }

        public bool MadeKill()
        {
            return true;
        }

        public virtual bool Migrates()
        {
            return true;
        }
    }
}
