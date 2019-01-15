using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.CLasses
{
    public class BlueMntTreeFrong : Amphibians
    {

        public bool Lives_In_Tree { get; set; } = true;
        public int Poison_Level { get; set; }

        public string Extend_Tongue()
        {
            return "Go go Gadget Tongue!";
        }
        
    }
}
