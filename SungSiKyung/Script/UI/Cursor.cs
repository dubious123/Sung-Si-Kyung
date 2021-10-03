using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Data;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Script.UI
{
    public class Cursor : GameObject_Static
    {
        LinkedListNode<Vector2Int> currentNode;
        Dictionary<Vector2Int, Button> _buttonDict = new Dictionary<Vector2Int, Button>();
        LinkedList<Vector2Int> _cursorRail = new LinkedList<Vector2Int>();
        public void AddRail(Vector2Int pos,Button btn)
        {
            if (_buttonDict.ContainsKey(pos)) { return; }
            _buttonDict.Add(pos,btn);
        }
        public void FixRail()
        {
            foreach (KeyValuePair<Vector2Int,Button> pair in _buttonDict)
            {
                LinkedListNode<Vector2Int> node = _cursorRail.Last;
                while(true)
                {
                    if(node == null)
                    {
                        _cursorRail.AddLast(pair.Key);
                        break;
                    }
                    if (node.Value.y < pair.Key.y)
                    {
                        _cursorRail.AddBefore(node, pair.Key);
                        break;
                    }

                    node = node.Next;
                }
            }
            Transform.Position = _cursorRail.First.Value;
            currentNode = _cursorRail.First;
        }
        public void MoveUp()
        {
            if (currentNode.Next == null) { return; }
            currentNode = currentNode.Next;
            Transform.Position = currentNode.Value;
        }
        public void MoveDown()
        {
            if (currentNode.Previous == null) { return; }
            currentNode = currentNode.Previous;
            Transform.Position = currentNode.Value;

        }
        public void InvokeCurrentBtn()
        {
            _buttonDict[currentNode.Value].OnClick();
        }
    }
}
