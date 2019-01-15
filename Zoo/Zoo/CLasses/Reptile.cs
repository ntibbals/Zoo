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

        public virtual string ShedSkin()
        {
            return "Molt, molt, molt";
        }

        public virtual string Migrates()
        {
            return "Let me migrate somewhere else";
        }
    }
}
