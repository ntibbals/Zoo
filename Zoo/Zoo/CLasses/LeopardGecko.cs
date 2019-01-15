using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class LeopardGecko : Reptile
    {
        public int horns { get; set; }
        public bool SaveMoney { get; set; } = return true;

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

    }
}
