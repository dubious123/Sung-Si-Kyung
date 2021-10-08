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
        public static Dictionary<string, Map> _mapDict = new Dictionary<string, Map>();

        public MapLibrary()
        {
            _mapDict.Add("map1", new Map(map1));
            _mapDict.Add("map2", new Map(map2));
        }


        public override Data FindBook(string id)
        {
            if (_mapDict.ContainsKey(id)) { return _mapDict[id]; }
            else { return null; }
        }
    }
}
