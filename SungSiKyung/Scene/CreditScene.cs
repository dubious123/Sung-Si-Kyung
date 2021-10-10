using SungSiKyung.Data;
using SungSiKyung.Script.Managers;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Scene
{
    public class CreditScene : BaseScene
    {
        public CreditScene()
        {
            SetInputMap();
            CreateCreditTexts();

        }
        void CreateCreditTexts()
        {
            GameObject_Static header = new GameObject_Static();
            header.Transform.Position = new Vector2Int(Define.ConsoleWidth / 2 - 3, Define.ConsoleHeight / 2 - 50);
            header.RenderingData = new Text("Credit");
            StaticSet.Add(header);
        }
        public override void SetInputMap()
        {
            base.SetInputMap();
            InputMap.GetAction("UpArrow").AddListener("UpArrow", () =>
            { Managers.CursorMgr.TranslatePosition(new Vector2Int(0, -1)); });
            InputMap.GetAction("DownArrow").AddListener("DownArrow", () =>
            { Managers.CursorMgr.TranslatePosition(new Vector2Int(0, 1)); });
        }
    }

}
