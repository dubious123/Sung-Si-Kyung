using SungSiKyung.Components;
using SungSiKyung.Data;
using SungSiKyung.Interfaces;
using SungSiKyung.Scene;
using SungSiKyung.Script.Content;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Managers
{
    public class PhysicManager
    {
        float _gravity;
        public Dictionary<Vector2Int, Collider> StaticColliderDict;
        public Dictionary<Vector2, Collider> DynamicColliderDict;
        public void Init()
        {
            _gravity = 0.98f;
            StaticColliderDict = new Dictionary<Vector2Int, Collider>();
        }
        public void ApplyPhysic(BaseScene scene)
        {
            DynamicColliderDict = new Dictionary<Vector2, Collider>();
            foreach (GameObject unit in scene.DynamicSet)
            {
                if(unit is IUseGravity) { ApplyGravity(unit); }
                CaculateCollides(unit);
                //Todo
                AdjustTransform(unit);
            }
        }
        void ApplyGravity(GameObject unit)
        {
            unit.Velocity += new Vector2(0, _gravity * Managers.TimingMgr.DeltaTime);
        }
        void AdjustTransform(GameObject unit)
        {
            unit.Transform.Position += unit.Velocity * Managers.TimingMgr.DeltaTime;
        }
        void CaculateCollides(GameObject unit)
        {
            if (!unit.HasComponent<Collider>()) { return; }
            Collider unitCollider = unit.GetComponent<Collider>();
            foreach (Vector2Int pos in StaticColliderDict.Keys)
            {
                Collider staticCollider = StaticColliderDict[pos];
                if ((pos - unit.Transform.Position).Magnitude > (unit.Transform.Size.Max()+staticCollider.gameObject.Transform.Size.Max())) { continue; }

                foreach (Vector2Int dot in staticCollider.ColliderDots)
                {
                    if (unitCollider.ColliderDots.Contains(dot))
                    {
                        staticCollider.InvokeColliderEvent(unit);
                        unitCollider.InvokeColliderEvent(staticCollider.gameObject);
                    }
                }
            }
            foreach (Vector2 pos in DynamicColliderDict.Keys)
            {
                if ((pos - unit.Transform.Position).Magnitude > (unit.Transform.Size.Max())) { continue; }
                Collider dynamicCollider = DynamicColliderDict[pos];
                foreach (Vector2Int dot in dynamicCollider.ColliderDots)
                {
                    if (unitCollider.ColliderDots.Contains(dot))
                    {
                        dynamicCollider.InvokeColliderEvent(unit);
                        unitCollider.InvokeColliderEvent(dynamicCollider.gameObject);
                    }
                }
            }

            DynamicColliderDict.Add(unit.Transform.Position, unit.GetComponent<Collider>());

        }
    }
}
