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
        public static Dictionary<string, Unit> _unitDict = new Dictionary<string, Unit>();

        public UnitLibrary()
        {
            _unitDict.Add("unit1", new Unit(unit1));
            _unitDict.Add("unit2", new Unit(unit2));
        }


        public override Data FindBook(string id)
        {
            if (_unitDict.ContainsKey(id)) { return _unitDict[id]; }
            else { return null; }
        }
    }
}
