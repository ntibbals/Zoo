using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface IHunt
    {
        string Hunting();
        bool FoundPrey();
        bool MadeKill();
    }
}
