using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public abstract class Mammal : Animal
    {
        public virtual bool Carnivore { get; set; } = true;
        public virtual bool Pack_Mentality { get; set; } = true;

        public bool Birthing()
        {
            return true;
        }
    }
}
