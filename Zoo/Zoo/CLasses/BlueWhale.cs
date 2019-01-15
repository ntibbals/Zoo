using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class BlueWhale : Aquatic
    {
        public override bool Carnivore { get; set; } = false;
        public bool Eats_Plankton { get; set; } = true;

        public string Sing()
        {
            return "Ooooooo OOOOoooooooo(whale noises)";
        }
    }
}
