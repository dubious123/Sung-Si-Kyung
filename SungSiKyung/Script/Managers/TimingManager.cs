using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Managers
{
    public class TimingManager
    {
        int _currentTick;
        float _waitTick;
        float _deltaTime;
        public float DeltaTime { get{ return _deltaTime; } }
        public void Init()
        {
            _waitTick =  1000f /Define.FRAME;
        }
        public bool FrameControl()
        {
            int deltaTick = Environment.TickCount - _currentTick;
            if (deltaTick < _waitTick) { return false; }
            _deltaTime = Math.Clamp((deltaTick),0, _waitTick)/1000f;
            _currentTick = Environment.TickCount;
            return true;
        }
    }
}
