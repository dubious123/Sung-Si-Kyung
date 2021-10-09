using SungSiKyung.Components;
using SungSiKyung.Data;
using SungSiKyung.Script.Controller;
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
            SetInputMap();
            base.StartScene();

            GameObject_Static floor = new GameObject_Static();
            floor.Transform.Boundary = new Box(-50, 50, -1, 1);
            floor.Transform.Position = new Vector2Int(50, 50);
            Collider floorCollider = new Collider(floor, 1f);
            floor.AddComponent(floorCollider);


            floor.RenderingData = new Image(new int[2, 100] { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } });
            AddGameObject(floor);
            Managers.PhysicMgr.StaticColliderDict.Add(new Vector2Int(26, 51), floorCollider);
            AddGameObject(Managers.GameMgr.CurrentPlayer);
        }
        public override void SetInputMap()
        {
            base.SetInputMap();
            PlayerController controller = Managers.GameMgr.CurrentPlayer.GetComponent<PlayerController>();
            InputMap.GetAction("LeftArrow").AddListener("LeftArrow", () => controller.MoveLeft());
            InputMap.GetAction("RightArrow").AddListener("RightArrow", () => controller.MoveRight());
        }
    }

}
