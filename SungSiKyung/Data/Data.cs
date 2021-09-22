using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public abstract class Data
    {
        public int[,] inputPixel;
        public abstract Data load();
    }
}
