using SungSiKyung.Data;
using SungSiKyung.Interfaces;
using SungSiKyung.Scene;
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
        public void Init()
        {
            _gravity = 0.98f;
        }
        public void ApplyPhysic(BaseScene scene)
        {
            foreach(GameObject unit in scene.unitSet)
            {
                if(unit is IUseGravity) { ApplyGravity(unit); }

                //Todo


                ApplyVelocity(unit);
            }
        }
        void ApplyGravity(GameObject unit)
        {
            unit.Velocity += new Vector2(0, _gravity * Managers.TimingMgr.DeltaTime);
        }
        void ApplyVelocity(GameObject unit)
        {
            unit.Transform.Position += unit.Velocity * Managers.TimingMgr.DeltaTime;
        }
    }
}
