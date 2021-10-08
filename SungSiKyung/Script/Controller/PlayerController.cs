using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Script.Managers;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Script.Controller
{

    public class PlayerController
    {
        
        public static void UpdatePlayerState()//idle_state에요
        {
            Vector2 Player_Velocity = Managers.Managers.GameMgr.CurrentPlayer.Velocity;
            if (Player_Velocity.Magnitude <= 0.01f)
            {
                Managers.Managers.GameMgr.CurrentPlayer.Current_Player_MoveState = Define.Player_MoveState.Idle;
            }
        }

        public static void UpdatePlayerStateOfMove()//Player의 Game상에서의 Run state
        {
            Vector2 Player_Velocity = Managers.Managers.GameMgr.CurrentPlayer.Velocity;
            if (Player_Velocity.x >= 0.01f && Player_Velocity.y <= 0.01f )
            {
                Managers.Managers.GameMgr.CurrentPlayer.Current_Player_MoveState = Define.Player_MoveState.Move;
            }
        }

        public static void UpdatePlayerStateOfJump()//Player의 Game상에서의 Jump state
        {
            Vector2 Player_Velocity = Managers.Managers.GameMgr.CurrentPlayer.Velocity;
            if (Player_Velocity.y >= 0.01f) 
            {
                Managers.Managers.GameMgr.CurrentPlayer.Current_Player_MoveState = Define.Player_MoveState.Jump;
            }
        }

        public static void UpdatePlayerStateAttack() //Player의 Game상에서의 Attack state
        {
            bool Player_Attacking = Managers.Managers.GameMgr.CurrentPlayer.Attacked;
        }
    
    }
}
