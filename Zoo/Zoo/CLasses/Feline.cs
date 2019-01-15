using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public abstract class Feline : Mammal
    {
        public bool Land_Based { get; set; } = true;
        public bool Has_paws { get; set; } = true;

        public string Roam()
        {
            return "Just roaming around....";
        }
    }
}
