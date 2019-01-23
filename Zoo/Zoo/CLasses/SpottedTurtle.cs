using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public class SpottedTurtle : Reptile, IMate
    {
        public bool Shell { get; set; } =  true;
        public override bool Dry_Skin { get; set; } = true;


        public string Mating()
        {
            return "You've got a pretty shell....";
        }

        public bool Reproducing()
        {
            return true;
        }

        public override string ShedSkin()
        {
            return "I don't molt but I've got a shell!";
        }
        public bool Swim()
        {
            return true;
        }
    }
}
