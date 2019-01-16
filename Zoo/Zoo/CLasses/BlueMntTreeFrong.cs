using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public class BlueMntTreeFrong : Amphibians, IMate, IHunt
    {

        public bool Lives_In_Tree { get; set; } = true;
        public int Poison_Level { get; set; }

        public string Extend_Tongue()
        {
            return "Go go Gadget Tongue!";
        }

        public bool FoundPrey()
        {
            return true;
        }

        public string Hunting()
        {
            return "I think I see a fly to catch....";
        }

        public bool MadeKill()
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
