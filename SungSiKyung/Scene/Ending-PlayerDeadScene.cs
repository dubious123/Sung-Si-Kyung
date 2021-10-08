using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Data;
using SungSiKyung.Script.Managers;
using SungSiKyung.Script.UI;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Scene
{
    public class Ending_PlayerDeadScene : BaseScene
    {
        public Ending_PlayerDeadScene()
        {
            Button youLose_go = new Button();
            youLose_go.Transform.Position = new Vector2Int(50, 30);
            youLose_go.RenderingData = new Text("You Lose");
            StaticSet.Add(youLose_go);
            AddGameObject(Managers.CursorMgr.CreateCursor());
            Managers.CursorMgr.SetCursorRail(new Vector2Int(50, 30), youLose_go);

        }
    }
}
