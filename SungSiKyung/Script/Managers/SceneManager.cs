using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Managers
{
    public class SceneManager
    {
        Define.SceneType _currentScene;
        public Define.SceneType CurrentScene { get { return _currentScene; } }
        public void Init()
        {
            _currentScene = Define.SceneType.Game;
        }
    }
}
