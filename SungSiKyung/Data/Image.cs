using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public class Image : Data
    {


        

        public Image(int[,] inputPixel)
        {
            this.inputPixel = inputPixel;
        }

        public override Data load()
        {
            return (Data)this;
        }
    }
}
