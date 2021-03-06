using SungSiKyung.Components;
using SungSiKyung.Scene;
using SungSiKyung.Script.Content;
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
        Enemy _enemy;
        Player _player;
        public Player CurrentPlayer 
        { get
            {
                if(_player == null) { CreatePlayer(); }
                return _player;
            } 
        }
        public Enemy Currentenemy
        {
            get
            {
                if (_enemy == null) { CreateEnemy(); }
                return _enemy;
            } 
        }
        
        public void Init()
        {
            
        }
        
        void CreatePlayer()
        {
            _player = new Player();
        }
        void CreateEnemy()
        {
            _enemy = new Enemy();
        }
        public void StartGame()
        {
            CreatePlayer();
            CreateEnemy();
            Managers.SceneMgr.SwitchScene(Define.SceneType.MainMenu);

            while (true)
            {
                Managers.InputMgr.GetInput();

                if (Managers.TimingMgr.FrameControl())
                {

                    Managers.RenderMgr.RenderScene();
                    Managers.PhysicMgr.ApplyPhysic(Managers.SceneMgr.CurrentScene);


                }


            }
        }
    }
}

