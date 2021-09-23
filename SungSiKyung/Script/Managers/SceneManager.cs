using SungSiKyung.Scene;
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
        public BaseScene CurrentScene { get { return _currentScene; } }
        List<BaseScene> _sceneBuffer;
        BaseScene _currentScene;
        public void Init()
        {
            //Todo --> Data
            _sceneBuffer = new List<BaseScene>();
            _currentScene = new GameScene();
            _sceneBuffer.Add(_currentScene);
        }
        public void SwitchScene(Define.SceneType type)
        {
            //Todo
            _currentScene.StartScene();
        }
    }
}
