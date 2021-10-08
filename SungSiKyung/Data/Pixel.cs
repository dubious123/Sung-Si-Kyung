using SungSiKyung.Components;
using SungSiKyung.Script.Managers;
using SungSiKyung.Script.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public class Pixel 
    {
        public Pixel(Vector2Int displacement, char shape,ConsoleColor color = ConsoleColor.White)
        {
            Displacement = displacement;
            Shape = shape;
            Color = color;
        }
        public void Print(Vector2Int center,GameObject go = null)
        {
            int y = Displacement.y + center.y;
            int x = Displacement.x + center.x;
            Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
            go?.GetComponent<Collider>()?.ColliderOffsets?.Add(Displacement);
        }
        public Vector2Int Displacement { get; set; }
        public char Shape { get; set; }
        public ConsoleColor Color { get; set; }
    }
}
