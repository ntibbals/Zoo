﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.CLasses
{
    public abstract class Feline : Mammal, IHunt
    {
        public abstract bool Land_Based { get; set; }
        public bool Has_paws { get; set; } = true;

        public bool FoundPrey()
        {
            throw new NotImplementedException();
        }

        public string Hunting()
        {
            return "On the prowl for some food";
        }

        public bool MadeKill()
        {
            return true;
        }

        public abstract string Roam();
  
    }
}
