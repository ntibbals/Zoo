using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public abstract class Aquatic : Mammal
    {
        public bool Water_Breathing { get; set; } = true;
        public bool Fins { get; set; } = true;

        public override int Number_Of_Legs { get => base.Number_Of_Legs; set => base.Number_Of_Legs = 0; }

        public abstract bool Swim();
    }
}
