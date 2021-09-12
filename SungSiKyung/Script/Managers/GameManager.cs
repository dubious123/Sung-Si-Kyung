using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Managers
{
    public class GameManager
    {
        public void Init()
        {

        }
        public void StartScene()
        {      
            while (true)
            {
                Managers.InputMgr.GetInput();
                if (Managers.TimingMgr.FrameControl())
                {
                    Console.WriteLine("SceneLoaded");
                }
            }
        }
    }
}
