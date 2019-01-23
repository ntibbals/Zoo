using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class Lion : Feline
    {
        public bool Mane { get; set; }

        public bool King_Of_Jungle { get; set; }
        public override bool Land_Based { get; set; } = true;

        public string Pack_Hunt()
        {
            return "Hunting with the pack.";
        }

        public override string Roam()
        {
            return "Roaming around in fields with my lioness";
        }
    }
}
