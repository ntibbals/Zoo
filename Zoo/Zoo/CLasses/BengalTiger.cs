using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class BengalTiger : Feline
    {
        public bool Orange_Black_Stripes { get; set; } = true;
        public bool Climber { get; set; } = true;
        public override bool Pack_Mentality { get; set; } = false;

        public string Climb()
        {
            return "Claw, claw, up a tree to find Mowgli.";
        }

        public string HideKill()
        {
            return "Let me hide my prey from other predators.";
        }
    }
}
