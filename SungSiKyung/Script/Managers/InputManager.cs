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
            Managers.SceneMgr.CurrentScene.InputMap.GetInput();
        }
    }
}
    
