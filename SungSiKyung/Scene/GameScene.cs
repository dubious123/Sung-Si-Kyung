using SungSiKyung.Components;
using SungSiKyung.Data;
using SungSiKyung.Script.Managers;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SungSiKyung.Scene
{
    public class GameScene : BaseScene
    {
        public GameScene()
        {
            AddGameObject(Managers.GameMgr.CurrentPlayer);

            SetInputMap();
            base.StartScene();
            AddGameObject(Managers.GameMgr.CurrentPlayer);
            AddGameObject(Managers.GameMgr.Currentenemy);
            GameObject_Static floor = new GameObject_Static();
            Collider floorCollider = new Collider(floor, 0.8f);
            floor.AddComponent(floorCollider);
            floor.Transform.Up = 1;
            floor.Transform.Down = 0;
            floor.Transform.Left = 25;
            floor.Transform.Right = 25;
            floor.Transform.Position = new Vector2Int(25, 50);

            floor.RenderingData = new Image(new int[1, 50] { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } });
            AddGameObject(floor);
            Managers.PhysicMgr.StaticColliderDict.Add(new Vector2Int(25, 50), floorCollider);
        }
        public override void SetInputMap()
        {
            base.SetInputMap();

        }
    }

}
