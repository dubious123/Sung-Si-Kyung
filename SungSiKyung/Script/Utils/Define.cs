using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Utils
{
    public class Define
    {
        public const int FRAME = 60;
        public const int ConsoleHeight = 63;
        public const int ConsoleWidth = 224; // 63/9*32
        public enum Dir
        {
            Up,
            Right,
            Down,
            Left
        }
        public enum SceneType 
        { 
            MainMenu,
            Game,
            Ending,
        }
        public enum Player_MoveState 
        {
            Idle,
            Move,
            Jump,
        }
         
    }
}
