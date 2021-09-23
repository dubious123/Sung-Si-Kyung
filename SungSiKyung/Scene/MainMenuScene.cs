using SungSiKyung.Data;
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
            GameObject_Static startGame_go = new GameObject_Static();
            startGame_go.RenderingData = new Text("Start Game");
            startGame_go.Transform.Position = new Vector2(50, 50);
            staticSet.Add(startGame_go);
        }

    }
}
