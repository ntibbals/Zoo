using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public abstract class Animal
    {
        public virtual int Number_Of_Legs { get; set; }

        public bool Tail { get; set; } = true;

        public string Eating()
        {
            return "Me eat food.";
        }

        public string Sleeping()
        {
            return "Me sleep.";
        }

    }
}
