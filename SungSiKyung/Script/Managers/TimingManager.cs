using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Managers
{
    public class TimingManager
    {
        int _currentTick;
        int _deltaTick;
        float _waitTick;
        float _deltaTime;
        float _sumTime;
        public float DeltaTime { get{ return _deltaTime; } }
        Stopwatch _clock;
        public void Init()
        {
            _waitTick =  1f /Define.FRAME;
            _clock = new Stopwatch();
            _clock.Start();
        }
        public bool UpdateTick()
        {
            //_deltaTick = Environment.TickCount - _currentTick;
            //_deltaTime = Math.Clamp(_deltaTick, 0, _waitTick) / 1000f;
            _deltaTime = _clock.ElapsedMilliseconds / 1000f;


            return true;    
        }
        public bool FrameControl()
        {
            UpdateTick();
            if(_deltaTime < _waitTick) { return false; }
            _clock.Reset();
            _clock.Start();
            return true;
            //if (_deltaTick < _waitTick) { return false; }
            //_deltaTime = Math.Clamp((_deltaTick), 0, _waitTick) / 1000f;
            //_currentTick = Environment.TickCount;
        }
    }
}
