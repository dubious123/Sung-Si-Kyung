using SungSiKyung.Data;
using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Script.UI
{
    public class Button : GameObject_Static
    {
        UnityEvent _onClickEvent = new UnityEvent();
        public void AddListener(string tag, Action func)
        {
            _onClickEvent.AddListener(tag, func);
        }
        public void RemoveListener(string tag)
        {
            _onClickEvent.RemoveListener(tag);
        }
        public void RemoveListener(Action func)
        {
            _onClickEvent.RemoveListener(func);
        }
        public void OnClick()
        {
            _onClickEvent.Invoke();
        }
        
    }
}
