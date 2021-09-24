using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Data
{
    class MapLibrary : BaseLibrary
    {
        public static int[,] map1 = {{ 0, 1, 1, 1, 1 },{0,1,1,1,1},{0,1,1,1,1},{0,1,1,1,1},{0,0,1,0,0},{0,1,1,1,0},
            {1,0,1,0,1},{1,0,1,0,1},{0,0,1,0,0},{0,1,0,1,0},{1,0,0,0,1},{1,0,0,0,1} };
        public static int[,] map2 = {{0,0,0,0,0},{0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,0,1,0,0},
            { 0,1,1,1,0},{ 1,0,1,0,1},{ 1,0,1,0,1},{ 0,1,0,1,0},{ 1,0,0,0,1},{ 1,0,0,0,1}};

        public MapLibrary()
        {
            ImageLibrary._imageDict.Add("map1", new Image(map1));
            ImageLibrary._imageDict.Add("map2", new Image(map2));
        }


        public override Data FindBook(string id)
        {
            if (ImageLibrary._imageDict.ContainsKey(id)) { return ImageLibrary._imageDict[id]; }
            else { return null; }
        }
    }
}
