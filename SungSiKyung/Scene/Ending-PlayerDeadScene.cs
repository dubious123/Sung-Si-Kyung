using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Data;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Scene
{
    public class Ending_PlayerDeadScene : BaseScene
    {
        public Ending_PlayerDeadScene()
        {
            GameObject_Static youLose_go = new GameObject_Static();
            youLose_go.Transform.Position = new Vector2Int(50, 30);
            youLose_go.RenderingData = new Text("You Lose");
            staticSet.Add(youLose_go);
          
        }
    }
}
