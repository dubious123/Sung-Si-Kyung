using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Data;
using SungSiKyung.Script.Controller;
using SungSiKyung.Script.Utils;
using SungSiKyung.Script.Content;


namespace SungSiKyung.Script.Managers
{

    public class InputManager
    {

        public void Init()
        {

        }

        public void GetInput()
        {


            if (Console.KeyAvailable == true)
            {
                ConsoleKeyInfo Input;
                Input = Console.ReadKey();
                if (Input.Key == ConsoleKey.UpArrow)
                    Managers.GameMgr.CurrentPlayer.Velocity.y += Managers.TimingMgr.DeltaTime;
                if (Input.Key == ConsoleKey.DownArrow)
                    Managers.GameMgr.CurrentPlayer.Velocity.y -= Managers.TimingMgr.DeltaTime;
                if (Input.Key == ConsoleKey.LeftArrow)
                    Managers.GameMgr.CurrentPlayer.Velocity.x += Managers.TimingMgr.DeltaTime;
                    Controller.PlayerController.UpdatePlayerStateOfMove();
                if (Input.Key == ConsoleKey.RightArrow)
                    Managers.GameMgr.CurrentPlayer.Velocity.x -= Managers.TimingMgr.DeltaTime;
                    Controller.PlayerController.UpdatePlayerStateOfMove();
                if (Input.Key == ConsoleKey.X)
                {
                    Attack();
                }
            }
            PlayerController.UpdatePlayerState();

            void Attack() 
            {
                if (Managers.GameMgr.CurrentPlayer.Attacked)
                {
                    Managers.GameMgr.Currentenemy.NowHp -= Managers.GameMgr.CurrentPlayer.AttackDamage;
                    Managers.GameMgr.CurrentPlayer.Attacked = false;
                    if (Managers.GameMgr.Currentenemy.NowHp <= 0)
                    {
                        //Enemy 객체 파괴
                    }
                }
            }


            /*switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Managers.GameMgr.CurrentPlayer.Velocity.y += Managers.TimingMgr.DeltaTime;
                    break;
                case ConsoleKey.DownArrow:
                    Managers.GameMgr.CurrentPlayer.Velocity.y -= Managers.TimingMgr.DeltaTime;
                    break;
                case ConsoleKey.LeftArrow:
                    Managers.GameMgr.CurrentPlayer.Velocity.x += Managers.TimingMgr.DeltaTime;
                    break;
                case ConsoleKey.RightArrow:
                    Managers.GameMgr.CurrentPlayer.Velocity.x -= Managers.TimingMgr.DeltaTime;
                    break;
                case ConsoleKey.X:
            }
            */

        }
    }
}
    
