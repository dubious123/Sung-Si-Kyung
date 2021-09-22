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
        public Pixel(Vector2Int placement,Char shape,ConsoleColor color)
        {
            Displacement = placement;
            Shape = shape;
            Color = color;
        }
        public Vector2Int Displacement { get; set; }
        public char Shape { get; set; }
        public ConsoleColor Color { get; set; }

        public object Current => throw new NotImplementedException();

        public IEnumerator<float> _TextCoroutine()
        {
            yield return 0f;
            yield break;
        }
    }
}
