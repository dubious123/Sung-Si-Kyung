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

        Dictionary<string, Image> dicPixel = new Dictionary<string, Image>()
        {
            {"idle1", new Image(pixel1) },
            {"idle2", new Image(pixel2) }
        };

        struct Vector
        {
            public static int X, Y;
        }

        public void Load<T>()
        {
            int x = Vector.X;
            int y = Vector.Y;
            for(int i=0;i<dicPixel["idle1"].inputPixel.GetLength(0);i++)
            {
                Console.SetCursorPosition(x, y);
                for(int j=0;j< dicPixel["idle1"].inputPixel.GetLength(1);j++)
                {
                    if (dicPixel["idle1"].inputPixel[i, j] == 1)
                        Console.Write("■");
                    else
                        Console.Write(" ");
                }
            }
        }
    }
}
