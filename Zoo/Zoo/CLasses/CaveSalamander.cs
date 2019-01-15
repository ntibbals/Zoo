using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class CaveSalamander : Amphibians
    {
        public bool Lives_In_Cave { get; set; } = true;
        public int Number_Of_Grooves { get; set; }

        public override string Ribbit()
        {
            return "Slither, slither";
        }

        public string RegrowTail()
        {
            return "Tail gets cut off, but it grows back again!";
        }
    }
}
