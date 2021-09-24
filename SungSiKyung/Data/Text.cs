using SungSiKyung.Script.Managers;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Data
{
    public class Text : RenderData
    {
        string TextData;
        public Text(string str)
        {
            TextData = str;
        }
        public void PrintText(Vector2Int pos)
        {
            int x = pos.x;
            int y = pos.y;
            foreach(char c in TextData)
            {
                Managers.RenderMgr.ScreenBuilder[y][x++] = c;

            }
        }
        public override Data load()
        {
            return this;
        }
    }
}
