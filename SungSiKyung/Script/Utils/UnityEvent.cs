using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Script.Utils
{
    public class UnityEvent
    {
        Dictionary<string, Action> _invokeDict = new Dictionary<string, Action>();
        public void AddListener(string tag, Action func)
        {
            _invokeDict.Add(tag, func);
        }
        public void RemoveListener(Action func)
        {
            if (_invokeDict.ContainsValue(func))
            {
                foreach (KeyValuePair<string, Action> pair in _invokeDict)
                {
                    if (pair.Value == func)
                    {
                        _invokeDict.Remove(pair.Key);
                    }
                }
            }
        }
        public void RemoveListener(string tag)
        {
            _invokeDict.Remove(tag);
        }
        public void Invoke()
        {
            foreach (Action action in _invokeDict.Values)
            {
                action.Invoke();
            }
        }
    }
}
