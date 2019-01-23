using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public class Orca : Aquatic, IHunt
    {
        public bool EyeSpots { get; set; }
        public bool WhiteBelly { get; set; }

        public bool FoundPrey()
        {
            return true;
        }

        public string Hunting()
        {
            return "Here fishy, fishy";
        }

        public string JumpRockBase()
        {
            return "Jumps rock base...Free Willy!!";
        }

        public bool MadeKill()
        {
            return true;
        }

        public override bool Swim()
        {
            return true;
        }
    }
}
