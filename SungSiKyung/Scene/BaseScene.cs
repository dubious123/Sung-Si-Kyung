using SungSiKyung.Data;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Script.Managers;
using SungSiKyung.Components;

namespace SungSiKyung.Scene
{
    public class BaseScene
    {
        public Define.SceneType Type;
        public HashSet<GameObject> unitSet = new HashSet<GameObject>();
        public HashSet<GameObject_Static> staticSet = new HashSet<GameObject_Static>();
        public void AddUnit<T>(T unit) where T : GameObject
        {
            unitSet.Add(unit);
        }
        public virtual void StartScene()
        {
            Managers.PhysicMgr.StaticColliderDict = new Dictionary<Vector2Int, Collider>();
            foreach (GameObject_Static go in staticSet)
            {
                if(go.HasComponent<Collider>()) { Managers.PhysicMgr.StaticColliderDict.Add(Vector2Int.RoundToInt(go.Transform.Position), go.GetComponent<Collider>()); }
            }
        }

    }
}
