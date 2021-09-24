using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Data
{
    class UnitLibrary : BaseLibrary
    {
        public static int[,] unit1 = {{ 0, 1, 1, 1, 1 },{0,1,1,1,1},{0,1,1,1,1},{0,1,1,1,1},{0,0,1,0,0},{0,1,1,1,0},
            {1,0,1,0,1},{1,0,1,0,1},{0,0,1,0,0},{0,1,0,1,0},{1,0,0,0,1},{1,0,0,0,1} };
        public static int[,] unit2 = {{0,0,0,0,0},{0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,0,1,0,0},
            { 0,1,1,1,0},{ 1,0,1,0,1},{ 1,0,1,0,1},{ 0,1,0,1,0},{ 1,0,0,0,1},{ 1,0,0,0,1}};

        public UnitLibrary()
        {
            ImageLibrary._imageDict.Add("unit1", new Image(unit1));
            ImageLibrary._imageDict.Add("idle2", new Image(unit2));
        }


        public override Data FindBook(string id)
        {
            if (ImageLibrary._imageDict.ContainsKey(id)) { return ImageLibrary._imageDict[id]; }
            else { return null; }
        }
    }
}
