using SungSiKyung.Data;
using SungSiKyung.Interfaces;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Content
{
    public class Player : GameObject, IUseGravity
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
        

        void AttackTrue() { Attacked = true;}
        void AttackFalse() { Attacked = false; }

    }
}