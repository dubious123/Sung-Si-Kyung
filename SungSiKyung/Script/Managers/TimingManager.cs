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
        float _deltaTime;
        public float DeltaTime { get{ return _deltaTime; } }
        public void Init()
        {
            _currentTick = 0;
        }
        public bool FrameControl()
        {
            if(Environment.TickCount - _currentTick < Define.FRAME) { return false; }
            _deltaTime = Math.Clamp((Environment.TickCount - _currentTick)/1000f,0,Define.FRAME/1000f);
            _currentTick = Environment.TickCount;
            return true;
        }
    }
}
