using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Data
{
    class Unit : Data
    {
        public int[,] unitimage;

        public Unit(int[,] unitimage)
        {
            this.unitimage = unitimage;
        }

        public override Data load()
        {
            return this;
        }
    }
}
