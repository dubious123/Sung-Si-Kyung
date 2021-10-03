using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.IO;

namespace SungSiKyung.Script.Managers
{
    public class SoundManager
    {
        SoundPlayer _currentPlayer = new SoundPlayer();
        string _defaultPath;
        public void Init()
        {
            _defaultPath = Managers.DataMgr.RootPath + @"Sounds\";
        }
        public void PlayBackground(string name)
        {
            _currentPlayer.SoundLocation = Path.Combine(_defaultPath, name + ".wav");
            _currentPlayer.Load();
            _currentPlayer.PlayLooping();
        }
        public void StopBackground()
        {
            _currentPlayer.Stop();
        }
        public void Clear()
        {

        }
    }
}
