using SungSiKyung.Components;
using SungSiKyung.Data;
using SungSiKyung.Interfaces;
using SungSiKyung.Script.Utils;
using SungSiKyung.Script.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Script.Controller;

namespace SungSiKyung.Script.Content
{
    public class Player : BaseUnit, IUseGravity
    {
        private Define.Player_MoveState _current_Player_MoveState;
        public Define.Player_MoveState Current_Player_MoveState
        {
            get
            {
                return _current_Player_MoveState;

            }
            set
            {
                _current_Player_MoveState = value;
            }
        }
        
        public int MaxHp;
        public int NowHp;
        public int AttackDamage;

        public bool Attacked = false;
        public Player()
        {
            Transform.Position = new Vector2(5, 5);
            Transform.Boundary = new Box(-2, 2, -2, 2);
            AddComponent(new Collider(this,1f));
            AddComponent(new Animator(this, "Ball"));
            AddComponent(new PlayerController(this));
        }

        void AttackTrue() { Attacked = true;}
        void AttackFalse() { Attacked = false; }

    }
}