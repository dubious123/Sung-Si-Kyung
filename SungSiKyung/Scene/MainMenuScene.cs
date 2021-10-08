using SungSiKyung.Data;
using SungSiKyung.Script.Managers;
using SungSiKyung.Script.UI;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Scene
{
    public class MainMenuScene : BaseScene
    {
        public MainMenuScene()
        {
            SetButtons();
            SetInputMap();
            AddGameObject(Managers.CursorMgr.CreateCursor());
            foreach (Button btn in ButtonList)
            {
                Managers.CursorMgr.SetCursorRail(btn.Transform.Position - new Vector2(3,0), btn);
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
            CreateButton("Start Game", new Vector2Int(100, 50),()=> Managers.SceneMgr.SwitchScene(Define.SceneType.Game));
            CreateButton("Exit Game", new Vector2Int(100, 40),()=>throw new Exception());
        }

    }
}
