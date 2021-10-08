using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Data
{
    public class InputActionMap
    {
        ConsoleKeyInfo Input;
        Dictionary<string, InputAction> _actionMap = new Dictionary<string, InputAction>();
        public InputAction GetAction(string name)
        {
            if (_actionMap.ContainsKey(name)) { return _actionMap[name]; }
            else { return null; }
        }
        public void AddInputAction(string name,ConsoleKeyInfo keyInfo,InputAction action = null)
        {
            if(action == null)
            {
                action = new InputAction();
            }
            _actionMap.Add(name, action);
            _actionMap[name].AddKeyInfo(keyInfo);

        }
        public void RemoveInputAction(string name)
        {
            if (!_actionMap.ContainsKey(name)) { return; }
            _actionMap[name] = null;
            _actionMap.Remove(name);
        }
        public void GetInput()
        {
            if (Console.KeyAvailable == false) { return; }
            Input = Console.ReadKey();
            foreach (InputAction inputAction in _actionMap.Values)
            {
                inputAction.Invoke(Input);
            }
        }
    }
}
