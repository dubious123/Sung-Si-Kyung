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
        public void Init()
        {
            _currentTick = 0;
        }
        public bool FrameControl()
        {
            if(Environment.TickCount - _currentTick < Define.FRAME) { return false; }
            _currentTick = Environment.TickCount;
            return true;
        }
    }
}
