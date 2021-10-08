using SungSiKyung.Components;
using SungSiKyung.Data;
using SungSiKyung.Interfaces;
using SungSiKyung.Scene;
using SungSiKyung.Script.Content;
using SungSiKyung.Script.Controller;
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
            _gravity = 9.8f;
            StaticColliderDict = new Dictionary<Vector2Int, Collider>();
        }
        public void ApplyPhysic(BaseScene scene)
        {
            DynamicColliderDict = new Dictionary<Vector2, Collider>();
            foreach (GameObject unit in scene.DynamicSet)
            {
                if (unit is IUseGravity) { ApplyGravity(unit); }
                //CaculateCollides(unit);

                AdjustTransform(unit);
                //Todo
            }
        }
        void ApplyGravity(GameObject unit)
        {
            unit.Velocity += new Vector2(0, _gravity * Managers.TimingMgr.DeltaTime);
        }
        void AdjustTransform(GameObject unit)
        {
            PlayerController controller = unit.GetComponent<PlayerController>();
            if (controller != null)
            {
                if (Math.Abs(unit.Velocity.x) > controller.MaxVelocity_Side)
                {
                    if (unit.Velocity.x < 0) { unit.Velocity.x = controller.MaxVelocity_Side * -1; }
                    else if (unit.Velocity.x >= 0) { unit.Velocity.x = controller.MaxVelocity_Side; }
                }
                if (Math.Abs(unit.Velocity.y) > controller.MaxVelocity_Up)
                {
                    if (unit.Velocity.y < 0) { unit.Velocity.y = controller.MaxVelocity_Up * -1; }
                    else if (unit.Velocity.y >= 0) { unit.Velocity.y = controller.MaxVelocity_Up; }
                }
            }
            float ratio = 0;
            Vector2 from = unit.Transform.Position;
            Vector2 dest = unit.Transform.Position + unit.Velocity;
            while (true)
            {
                ratio += Managers.TimingMgr.DeltaTime;
                unit.Transform.Position = Vector2.Lerp(from, dest, ratio);
                CalculateCollision(unit);
                if(ratio > 1) { break; }
            }
        }
        void CalculateCollision(GameObject unit)
        {
            foreach (GameObject_Static go_st in Managers.SceneMgr.CurrentScene.StaticSet)
            {
                if (Box.CheckOverlap(go_st, unit))
                {
                    go_st.GetComponent<Collider>()?.InvokeColliderEvent(unit);
                    unit.GetComponent<Collider>()?.InvokeColliderEvent(unit);
                }
            }
        }

        void CaculateCollides(GameObject unit)
        {
            if (!unit.HasComponent<Collider>()) { return; }
            Collider unitCollider = unit.GetComponent<Collider>();
            foreach (Vector2Int pos in StaticColliderDict.Keys)
            {
                Collider staticCollider = StaticColliderDict[pos];
                //if ((pos - unit.Transform.Position).Magnitude > (unit.Transform.Size.Max()+staticCollider.gameObject.Transform.Size.Max())) { continue; }

                foreach (Vector2Int dot in staticCollider.ColliderDots)
                {
                    if (unitCollider.ColliderDots.Contains(dot))
                    {
                        staticCollider.InvokeColliderEvent(unit);
                        unitCollider.InvokeColliderEvent(staticCollider.gameObject);
                        break;
                    }
                }
            }
            foreach (Vector2 pos in DynamicColliderDict.Keys)
            {
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
