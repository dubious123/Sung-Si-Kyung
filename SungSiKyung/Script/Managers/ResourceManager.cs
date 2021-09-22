using SungSiKyung.Data;
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


        public class Pixel
        {

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
        public void something(int a)
        {
            //Do somethong
        }
        public void something(string a)
        {
            Load<Image>("idle1");
        }
        public static T Load<T>(string _value) where T : Data.Data
        {

            if (ResourceManager.dicPixel.ContainsKey(_value))
                return dicPixel[_value].inputPixel;

            else
                return null;
        }
    }
}
