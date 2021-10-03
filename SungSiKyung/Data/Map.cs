using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Data
{
    class Map : Data
    {
        public int[,] mapimage;

        public Map(int[,] mapimage)
        {
            this.mapimage = mapimage;
        }

        public override Data load()
        {
            return this;
        }
    }
}
