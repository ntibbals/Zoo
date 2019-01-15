using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class Orca : Aquatic
    {
        public bool EyeSpots { get; set; }
        public bool WhiteBelly { get; set; }

        public string JumpRockBase()
        {
            return "Free Willy!!";
        }
    }
}
