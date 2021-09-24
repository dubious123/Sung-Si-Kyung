using SungSiKyung.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Script.Content;

namespace SungSiKyung.Script.Utils
{
    public static class Extension
    {
        static void PrintUnit(this BaseUnit unit)
        {
            unit.PrintUnit();
        }
        static void PrintStatic(this GameObject_Static static_go)
        {
            static_go.PrintStatic();
        }
        

    }
}
