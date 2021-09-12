using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Managers
{
    public class Managers
    {
        static Managers _instance;
        public static Managers Instance 
        { 
            get 
            { 
                if(_instance == null) { Init(); }
                return _instance; 
            } 
        }

        SceneManager _sceneMgr = new SceneManager();
        GameManager _gameMgr = new GameManager();
        InputManager _inputMgr = new InputManager();
        ResourceManager _resourceMgr = new ResourceManager();
        TimingManager _timingMgr = new TimingManager();

        public static SceneManager SceneMgr { get { return Instance._sceneMgr; } }
        public static GameManager GameMgr { get { return Instance._gameMgr; } }
        public static InputManager InputMgr { get { return Instance._inputMgr; } }
        public static ResourceManager ResourceMgr { get { return Instance._resourceMgr; } }
        public static TimingManager TimingMgr { get { return Instance._timingMgr; } }
        static void Init()
        {
            _instance = new Managers();
            _instance._sceneMgr.Init();
            _instance._gameMgr.Init();
            _instance._inputMgr.Init();
            _instance._resourceMgr.Init();
            _instance._timingMgr.Init();
        }   
    }
}
