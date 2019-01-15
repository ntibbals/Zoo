using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public abstract class Amphibians : Animal
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
    }
}
