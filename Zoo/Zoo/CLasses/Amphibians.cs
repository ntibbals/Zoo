using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public abstract class Amphibians : Animal, IMate
    {
        public bool Stripped { get; set; } = true;
        public bool Cold_Blooded { get; set; } = true;

        public virtual string Ribbit()
        {
            return "Ribbit, Ribbit";
        }

        public virtual bool LaysEggs()
        {
            return true;
        }

        public string Mating()
        {
            return "Let's get it on";
        }

        public bool Reproducing()
        {
            return true;
        }
    }
}
