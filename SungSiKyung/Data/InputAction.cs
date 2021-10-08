using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Data
{
    public class InputAction
    {
        UnityEvent InputEvent = new UnityEvent();
        HashSet<ConsoleKeyInfo> _keyInfoSet = new HashSet<ConsoleKeyInfo>();
        public void AddKeyInfo(ConsoleKeyInfo keyInfo)
        {
            if (_keyInfoSet.Contains(keyInfo)) { return; }
            _keyInfoSet.Add(keyInfo);
        }
        public void AddListener(string tag, Action func)
        {
            InputEvent.AddListener(tag, func);
        }
        public void RemoveListener(Action func)
        {
            InputEvent.RemoveListener(func);
        }
        public void RemoveListener(string tag)
        {
            InputEvent.RemoveListener(tag);
        }
        public void Invoke(ConsoleKeyInfo Input)
        {
            if (!_keyInfoSet.Contains(Input)) { return; }
            InputEvent.Invoke();
        }
    }
}
