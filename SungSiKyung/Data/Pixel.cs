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
        public void Print(Vector2Int center)
        {
            int y = Displacement.y + center.y;
            int x = Displacement.x + center.x;
            if (x < 0 || x > Define.ConsoleWidth * 2 - 1) { return; }
            if (y < 0 || y > Define.ConsoleHeight * 2 - 1) { return; }
            if (Shape == ' ')
            {
                if (Managers.RenderMgr.ScreenBuilder[y][x] == '\0' && Managers.RenderMgr.ScreenBuilder[y][x - 1] == '\0')
                {
                    Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                }
            }
            else if (Shape == '\0')
            {
                if (Managers.RenderMgr.ScreenBuilder[y][x + 1] == '\0')
                {
                    Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                    Managers.RenderMgr.ScreenBuilder[y][x + 1] = '#';
                }
                else
                {
                    Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                }
            }
            else if (Shape == '@') // x 한칸짜리
            {
                if (Managers.RenderMgr.ScreenBuilder[y][x] == '\0')
                {
                    if (Managers.RenderMgr.ScreenBuilder[y][x - 1] == '\0')
                    {
                        Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                    }
                    else
                    {
                        Managers.RenderMgr.ScreenBuilder[y][x - 1] = '#';
                        Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                    }
                }
                else if (Managers.RenderMgr.ScreenBuilder[y][x] == '■' || Managers.RenderMgr.ScreenBuilder[y][x] == '□')
                {
                    Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                    Managers.RenderMgr.ScreenBuilder[y][x + 1] = '#';
                }
                else
                {
                    Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                }
            }
            else // x 두칸짜리
            {
                if (Managers.RenderMgr.ScreenBuilder[y][x] == '\0')
                {
                    Managers.RenderMgr.ScreenBuilder[y][x - 1] = '#';
                    Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                }
                else
                {
                    Managers.RenderMgr.ScreenBuilder[y][x] = Shape;
                }
            }
            //Managers.RenderMgr.ScreenBuilder[y][x] = Shape;           
        }
        public Vector2Int Displacement { get; set; }
        public char Shape { get; set; }
        public ConsoleColor Color { get; set; }
    }
}
