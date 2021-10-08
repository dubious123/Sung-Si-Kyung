using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public class _Transform
    {
        public Vector2 Position = new Vector2(10, 20);
        public int[] Size = new int[4];
        public int Right { get { return Size[0]; } set { Size[0] = value; } }
        public int Up { get { return Size[1]; } set { Size[1] = value; } }
        public int Left { get { return Size[2]; } set { Size[2] = value; } }
        public int Down { get { return Size[3]; } set { Size[3] = value; } }
    }
}
