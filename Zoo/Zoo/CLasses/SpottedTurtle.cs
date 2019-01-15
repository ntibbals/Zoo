using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class SpottedTurtle : Reptile
    {
        public bool Shell { get; set; } =  true;

        public bool Swim()
        {
            return true;
        }
    }
}
