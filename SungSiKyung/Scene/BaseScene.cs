using SungSiKyung.Data;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Script.Managers;
using SungSiKyung.Components;
using SungSiKyung.Script.UI;

namespace SungSiKyung.Scene
{
    public class BaseScene
    {
        public InputActionMap InputMap;
        public string BackgroundMusic;
        public Define.SceneType Type;
        public HashSet<GameObject> DynamicSet = new HashSet<GameObject>();
        public HashSet<GameObject_Static> StaticSet = new HashSet<GameObject_Static>();
        protected List<Button> ButtonList = new List<Button>();
        public BaseScene()
        {
            BackgroundMusic = "180";
        }
        public void AddGameObject<T>(T go) where T : GameObject
        {
            if(go is GameObject_Static) { StaticSet.Add(go as GameObject_Static); return; }
            DynamicSet.Add(go);
        }
        public virtual void StartScene()
        {
            Managers.SoundMgr.PlayBackground(BackgroundMusic);
            Managers.PhysicMgr.StaticColliderDict = new Dictionary<Vector2Int, Collider>();
            foreach (GameObject_Static go in StaticSet)
            {
                if(go.HasComponent<Collider>()) { Managers.PhysicMgr.StaticColliderDict.Add(Vector2Int.RoundToInt(go.Transform.Position), go.GetComponent<Collider>()); }
            }
        }
        public virtual void SetInputMap()
        {
            InputMap = new InputActionMap();
            InputMap.AddInputAction("UpArrow",new ConsoleKeyInfo((char)0,ConsoleKey.UpArrow,false,false,false) ,new InputAction());
            InputMap.AddInputAction("DownArrow", new ConsoleKeyInfo((char)0, ConsoleKey.DownArrow, false, false, false), new InputAction());
            InputMap.AddInputAction("LeftArrow", new ConsoleKeyInfo((char)0, ConsoleKey.LeftArrow, false, false, false), new InputAction());
            InputMap.AddInputAction("RightArrow", new ConsoleKeyInfo((char)0, ConsoleKey.RightArrow, false, false, false), new InputAction());
            InputMap.AddInputAction("Enter", new ConsoleKeyInfo((char)13, ConsoleKey.Enter, false, false, false));
        }
        public virtual void SetButtons()
        {

        }
        public void CreateButton(string text, Vector2Int pos, Action action)
        {
            Button btn = new Button();
            btn.RenderingData = new Text(text);
            btn.Transform.Position = pos;
            AddGameObject(btn);
            ButtonList.Add(btn);
            btn.AddListener(text,action);
        }
    }
}
