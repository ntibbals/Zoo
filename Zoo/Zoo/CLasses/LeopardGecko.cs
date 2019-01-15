using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public class LeopardGecko : Reptile, IHunt
    {
        public int horns { get; set; }
        public bool SaveMoney { get; set; } = true;

        public override bool Migrates()
        {
            return false;
        }

        public string Insurance_Quote()
        {
            return "I can save you money by switching to Gecko";
        }

        public string Burrow()
        {
            return "Burrow, burrow, burrow";
        }

        public string Hunting()
        {
            return "Looking for some bugs...";
        }

        public bool FoundPrey()
        {
            return true;
        }

        public bool MadeKill()
        {
            return true;
        }
    }
}
