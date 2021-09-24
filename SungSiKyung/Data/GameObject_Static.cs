using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public class GameObject_Static : GameObject
    {
        public void PrintStatic()
        {
            //Todo
            if (RenderingData == null) { return; }
            if (RenderingData is Image)
            {
                (RenderingData as Image).PrintImage(new Vector2Int((int)Transform.Position.x, (int)Transform.Position.y),this);
                return;
            }
            if (RenderingData is Text)
            {
                (RenderingData as Text).PrintText(new Vector2Int((int)Transform.Position.x, (int)Transform.Position.y));
            }
        }
    }
}
