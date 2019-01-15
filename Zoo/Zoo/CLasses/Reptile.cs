using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public abstract class Reptile : Animal
    {
        public bool Dry_Skin { get; set; }
        public virtual int Num_Spots { get; set; }

        public virtual bool Lays_Eggs()
        {
            return true;
        }

        public virtual bool Migrates()
        {
            return true;
        }
    }
}
