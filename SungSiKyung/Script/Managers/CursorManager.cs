using SungSiKyung.Data;
using SungSiKyung.Script.UI;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Script.Managers
{
    public class CursorManager
    {
        public char DefaultCursor = '►';
        public Cursor CurrentCursor;
        public void Init()
        {

        }
        public Cursor CreateCursor(char cursor = ' ')
        {
            if(cursor == ' ') { cursor = DefaultCursor; }
            CurrentCursor = new Cursor();
            CurrentCursor.RenderingData = new Text($"{cursor}");
            return CurrentCursor;
        }
        public void SetCursorRail(Vector2 pos,Button btn)
        {
            SetCursorRail(Vector2Int.RoundToInt(pos), btn);
        }
        public void SetCursorRail(Vector2Int pos, Button btn)
        {
            CurrentCursor.AddRail(pos, btn);
        }
        public void TranslatePosition(Vector2Int pos)
        {
            if (pos.y > 0) { CurrentCursor.MoveDown(); }
            else { CurrentCursor.MoveUp(); }
        }
        public void ClickButton()
        {
            CurrentCursor.InvokeCurrentBtn();
        }
    }
}
