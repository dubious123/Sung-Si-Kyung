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
        Dictionary<Define.SceneType,BaseScene> _sceneBuffer;
        BaseScene _currentScene;
        public void Init()
        {
            //Todo --> Data
            _sceneBuffer = new Dictionary<Define.SceneType, BaseScene>();
            _currentScene = new MainMenuScene();
            _sceneBuffer.Add(_currentScene.Type, _currentScene);
        }
        public void SwitchScene(Define.SceneType type)
        {
            //Todo
            if (_sceneBuffer.ContainsKey(type)) { _currentScene = _sceneBuffer[type]; }
            else 
            { 
                _currentScene = CreateScene(type);
                _sceneBuffer.Add(type, _currentScene);
            }
            _currentScene.StartScene();
        }
        BaseScene CreateScene(Define.SceneType type)
        {
            switch (type)
            {
                case Define.SceneType.MainMenu:
                    return new MainMenuScene();
                case Define.SceneType.Game:
                    return new GameScene();
                case Define.SceneType.Ending:
                    return new Ending_PlayerDeadScene();
                default:
                    return null;
            }
        }
    }
}
