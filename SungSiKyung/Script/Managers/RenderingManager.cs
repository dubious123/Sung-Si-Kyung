using SungSiKyung.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using SungSiKyung.Data;
using SungSiKyung.Script.Utils;
using SungSiKyung.Script.Content;
using SungSiKyung.Script.Rendering;

namespace SungSiKyung.Script.Managers
{
    public class RenderingManager
    {
        //    [DllImport("")]
        //    static extern IntPtr GetConsoleWindow();
        public char[][] ScreenBuilder { get { return _builder; } }
        char[][] _builder;
        StringBuilder _sb;
        int ConsoleWidthLength;
        int ConsoleHeightLength;
        int _builderWidthLength;
        int _builderHeightLength;
        RenderData BGdata;
        Vector2Int BGpos;
        int CameraX;
        int CameraY;
        public void Init()
        {
            //Test
            _sb = new StringBuilder();
            Console.CursorVisible = false;
            SetWindowSize();
            ConsoleWidthLength = Console.WindowWidth;
            ConsoleHeightLength = Console.WindowHeight;
            _builderWidthLength = Console.WindowWidth * 2;
            _builderHeightLength = Console.WindowHeight * 2;
            CameraX = 0;
            CameraY = 0;

            _builder = new char[_builderHeightLength][];
            for (int i = 0; i < _builderHeightLength; i++)
            {
                _builder[i] = new char[_builderWidthLength];
                /*
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    _builder[i][j] = ' ';

                }
                */
            }
            BGdata = null;
            BGpos = new Vector2Int(Define.ConsoleWidth, Define.ConsoleHeight);
        }
        void SetWindowSize()
        {
            Console.SetWindowSize(64, 18);
            Console.SetBufferSize(Define.ConsoleWidth, Define.ConsoleHeight);
            while (true)
            {
                try
                {
                    Console.SetWindowSize(Define.ConsoleWidth, Define.ConsoleHeight);
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("콘솔 글꼴 크기를 줄여주세요! (권장 6)");
                    Console.SetCursorPosition(0, 0);
                }
            }
        }
        void ClearConsole()
        {
            _sb.Clear();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < _builderHeightLength; i++)
            {
                _builder[i] = new char[_builderWidthLength];
                for (int j = 0; j < _builderWidthLength; j++)
                {
                    _builder[i][j] = ' ';
                }
            }
        }
        public void RenderScene()
        {
            ClearConsole();
            RenderBG(Managers.SceneMgr.CurrentScene);
            Animator.ApplyAnimator(Managers.SceneMgr.CurrentScene);
            RenderDynamic();
            RenderStatic();
            Camera();
            for (int y = CameraY; y < CameraY + _builder.GetLength(0) / 2 - 1; y++)
            {
                _sb.AppendLine(BuilderToString(_builder[y]));
            }
            _sb.Append(BuilderToString(_builder[CameraY + _builderHeightLength / 2 - 1]));
            Console.Write(_sb);
        }
        void RenderDynamic()
        {
            foreach (BaseUnit unit in Managers.SceneMgr.CurrentScene.DynamicSet)
            {
                unit.PrintUnit();
            }
        }
        void RenderStatic()
        {
            foreach (GameObject_Static static_go in Managers.SceneMgr.CurrentScene.StaticSet)
            {
                static_go.PrintStatic();
            }
        }
        void RenderBG(BaseScene scene) //배경
        {
            switch (scene.Type)
            {
                case Define.SceneType.MainMenu:
                    BGdata = null;
                    break;
                case Define.SceneType.Game:
                    BGdata = Librarys.Find<Image>("BG2");
                    break;
                case Define.SceneType.Ending_PlayerDead:
                    BGdata = null;
                    break;
                default:
                    BGdata = null;
                    break;
            }
            if (BGdata != null)
            {
                (BGdata as Image).PrintImage(BGpos);
            }
        }

        void Camera()
        {
            int x = 0;
            int y = 0;
            x = (int)Managers.GameMgr.CurrentPlayer.Transform.Position.x;
            y = (int)Managers.GameMgr.CurrentPlayer.Transform.Position.y;
            if (x < _builderWidthLength / 4)
            {
                CameraX = 0;
            }
            else if (x > _builderWidthLength * 3 / 4)
            {
                CameraX = _builderWidthLength / 2;
            }
            else
            {
                CameraX = x - _builderWidthLength / 4;
            }

            if (y < _builderHeightLength / 4)
            {
                CameraY = 0;
            }
            else if (y > _builderHeightLength * 3 / 4)
            {
                CameraY = _builderHeightLength / 2;
            }
            else
            {
                CameraY = y - _builderHeightLength / 4;
            }
        }
        /*
        void RenderBuilder()
        {
            for (int y = 0; y < _builder.GetLength(0) - 1; y++)
            {
                _sb.AppendLine(new string(_builder[y]));
            }
            _sb.Append(new string(_builder[_builderHeightLength - 1]));
            Console.Write(_sb);
        }
        */
        string BuilderToString(char[] builder)
        {
            string s;
            if (builder[CameraX + _builderWidthLength / 2 - 1] == '\0')
            {
                if (builder[CameraX] == '\0')
                {
                    s = " " + new string(builder).Substring(CameraX, _builderWidthLength / 2 - 1);
                }
                else
                {
                    s = new string(builder).Substring(CameraX, _builderWidthLength / 2 - 1);
                }
            }
            else
            {
                if (builder[CameraX] == '\0')
                {
                    s = " " + new string(builder).Substring(CameraX, _builderWidthLength / 2 - 1) + " ";
                }
                else
                {
                    s = new string(builder).Substring(CameraX, _builderWidthLength / 2 - 1) + " ";
                }
            }
            return s;
        }
    }
}
