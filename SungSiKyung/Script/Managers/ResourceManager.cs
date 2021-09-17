using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Managers
{
    public class ResourceManager
    {
        public void Init()
        {

        }

        public class Image
        {

            public int[,] inputPixel;

            public Image(int[,] inputPixel)
            {
                this.inputPixel = inputPixel;
            }
        }

        public static int[,] pixel1 = {{ 0, 1, 1, 1, 1 },{0,1,1,1,1},{0,1,1,1,1},{0,1,1,1,1},{0,0,1,0,0},{0,1,1,1,0},
            {1,0,1,0,1},{1,0,1,0,1},{0,0,1,0,0},{0,1,0,1,0},{1,0,0,0,1},{1,0,0,0,1} };
        public static int[,] pixel2 = {{0,0,0,0,0},{0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,0,1,0,0},
            { 0,1,1,1,0},{ 1,0,1,0,1},{ 1,0,1,0,1},{ 0,1,0,1,0},{ 1,0,0,0,1},{ 1,0,0,0,1}};

        static Dictionary<string, Image> dicPixel = new Dictionary<string, Image>()
        {
            {"idle1", new Image(pixel1) },
            {"idle2", new Image(pixel2) }
        };

        public static int[,] Load(string _value)
        {

            if (ResourceManager.dicPixel.ContainsKey(_value))
                return dicPixel[_value].inputPixel;

            else
                return null;
        }
    }
}
