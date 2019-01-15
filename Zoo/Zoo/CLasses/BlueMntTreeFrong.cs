using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public class BlueMntTreeFrong : Amphibians, IMate
    {

        public bool Lives_In_Tree { get; set; } = true;
        public int Poison_Level { get; set; }

        public string Extend_Tongue()
        {
            return "Go go Gadget Tongue!";
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
