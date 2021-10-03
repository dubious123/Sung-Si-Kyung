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

        DataManager _dataMgr = new DataManager();
        SceneManager _sceneMgr = new SceneManager();
        GameManager _gameMgr = new GameManager();
        InputManager _inputMgr = new InputManager();
        PhysicManager _physicMgr = new PhysicManager();
        RenderingManager _renderMgr = new RenderingManager();
        ResourceManager _resourceMgr = new ResourceManager();
        SoundManager _soundMgr = new SoundManager();
        TimingManager _timingMgr = new TimingManager();

        public static DataManager DataMgr { get { return Instance._dataMgr; } }
        public static SceneManager SceneMgr { get { return Instance._sceneMgr; } }
        public static GameManager GameMgr { get { return Instance._gameMgr; } }
        public static InputManager InputMgr { get { return Instance._inputMgr; } }
        public static PhysicManager PhysicMgr { get { return Instance._physicMgr; } }
        public static RenderingManager RenderMgr { get { return Instance._renderMgr; } }
        public static ResourceManager ResourceMgr { get { return Instance._resourceMgr; } }
        public static SoundManager SoundMgr { get { return Instance._soundMgr; } }
        public static TimingManager TimingMgr { get { return Instance._timingMgr; } }
        static void Init()
        {
            _instance = new Managers();
            _instance._dataMgr.Init();
            _instance._sceneMgr.Init();
            _instance._gameMgr.Init();
            _instance._inputMgr.Init();
            _instance._physicMgr.Init();
            _instance._renderMgr.Init();
            _instance._resourceMgr.Init();
            _instance._soundMgr.Init();
            _instance._timingMgr.Init();
        }   
    }
}
