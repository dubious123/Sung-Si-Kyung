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
            SetInputMap();
            SetButtons();
            GameObject_Static youLose_go = new GameObject_Static();
            youLose_go.Transform.Position = new Vector2Int(Define.ConsoleWidth / 2 - 4, Define.ConsoleHeight / 2 - 15);
            youLose_go.RenderingData = new Text("You Lose");
            StaticSet.Add(youLose_go);
            AddGameObject(Managers.CursorMgr.CreateCursor());
            foreach (Button btn in ButtonList)
            {
                Managers.CursorMgr.SetCursorRail(btn.Transform.Position - new Vector2(3, 0), btn);
            }
            Managers.CursorMgr.CurrentCursor.FixRail();

        }
        public override void SetInputMap()
        {
            base.SetInputMap();
            InputMap.GetAction("UpArrow").AddListener("UpArrow", () =>
            { Managers.CursorMgr.TranslatePosition(new Vector2Int(0, -1)); });
            InputMap.GetAction("DownArrow").AddListener("DownArrow", () =>
            { Managers.CursorMgr.TranslatePosition(new Vector2Int(0, 1)); });
            InputMap.GetAction("Enter").AddListener("Enter", () =>
            { Managers.CursorMgr.ClickButton(); });
        }
        public override void SetButtons()
        {
            base.SetButtons();
            CreateButton("Restart Game", new Vector2Int(Define.ConsoleWidth / 2 - 6, Define.ConsoleHeight / 2 - 5), () => Managers.SceneMgr.SwitchScene(Define.SceneType.Game));
            CreateButton("Credit", new Vector2Int(Define.ConsoleWidth / 2 - 3, Define.ConsoleHeight / 2 + 5), () => Managers.SceneMgr.SwitchScene(Define.SceneType.Credit));
        }
    }
}
