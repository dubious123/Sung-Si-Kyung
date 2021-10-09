using SungSiKyung.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Script.Utils
{
    public class Box
    {
        public HashSet<Vector2Int> Bounds = new HashSet<Vector2Int>();
        public int Xmin;
        public int Xmax;
        public int Ymin;
        public int Ymax;
        public Box(int xmin, int xmax, int ymin, int ymax)
        {
            Xmin = xmin;
            Xmax = xmax;
            Ymin = ymin;
            Ymax = ymax;
            for (int x = xmin; x <= xmax; x++)
            {
                Bounds.Add(new Vector2Int(ymin, x));
                Bounds.Add(new Vector2Int(ymax, x));
            }
            for(int y = ymin; y <= ymax; y++)
            {
                Bounds.Add(new Vector2Int(y, xmin));
                Bounds.Add(new Vector2Int(y, xmax));
            }
        }
        public static bool CheckOverlap(GameObject go1,GameObject go2)
        {
            int x1;
            int x2;
            int y1;
            int y2;
            Vector2 dist = go2.Transform.Position - go1.Transform.Position;
            if(dist.x > 0) { x1 = go1.Transform.Boundary.Xmax; x2 = go2.Transform.Boundary.Xmin; }
            else { x1 = go1.Transform.Boundary.Xmin; x2 = go2.Transform.Boundary.Xmax; }
            if (dist.y > 0) { y1 = go1.Transform.Boundary.Ymax; y2 = go2.Transform.Boundary.Ymin; }
            else { y1 = go1.Transform.Boundary.Ymin; y2 = go2.Transform.Boundary.Ymax; }
            return Math.Abs(dist.x) < Math.Abs(x1) + Math.Abs(x2) && Math.Abs(dist.y) < Math.Abs(y1) + Math.Abs(y2);
        }
    }
}
