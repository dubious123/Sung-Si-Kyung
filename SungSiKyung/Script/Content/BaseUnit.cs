using SungSiKyung.Data;
using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Script.Content
{
    public class BaseUnit : GameObject 
    {
        public void PrintUnit()
        {
            Vector2Int pos = new Vector2Int((int)Transform.Position.x, (int)Transform.Position.y);
            (RenderingData as Image).PrintImage(pos);
        }
    }
}
