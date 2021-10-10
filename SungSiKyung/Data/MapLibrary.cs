using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Data
{
    class MapLibrary : BaseLibrary
    {
        public static Dictionary<string, Map> _mapDict = new Dictionary<string, Map>();

        public MapLibrary()
        {

        }


        public override Data FindBook(string id)
        {
            if (_mapDict.ContainsKey(id)) { return _mapDict[id]; }
            else { return null; }
        }
    }
}
