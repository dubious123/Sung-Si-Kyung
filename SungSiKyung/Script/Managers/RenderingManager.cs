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

namespace SungSiKyung.Script.Managers
{
    public class RenderingManager
    {
        //    [DllImport("")]
        //    static extern IntPtr GetConsoleWindow();
        public char[][] ScreenBuilder { get { return _builder; } }
        char[][] _builder; 
        StringBuilder _sb;
        int _builderWidthLength;
        int _builderHeightLength;
        public void Init()
        {
            //Test
            _sb = new StringBuilder();
            Console.CursorVisible = false;
            Console.SetWindowSize(224, 63);
            //Console.SetBufferSize(224, 63);
            SetWindowSize();

            _builderWidthLength = Console.WindowWidth;
            _builderHeightLength = Console.WindowHeight;

            _builder = new char[Console.WindowHeight][];
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                _builder[i] = new char[Console.WindowWidth];
                /*
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    _builder[i][j] = ' ';

                }
                */
            }
        }
        void SetWindowSize()
        {
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
            RenderBG();
            RenderDynamic();
            RenderStatic();
            for (int y = 0; y < _builder.GetLength(0) - 1; y++)
            {
                _sb.AppendLine(new string(_builder[y]));
            }
            _sb.Append(new string(_builder[Console.WindowHeight - 1]));
            Console.Write(_sb);
        }
        void RenderDynamic()
        {
            foreach (BaseUnit unit in Managers.SceneMgr.CurrentScene.unitSet)
            {
                unit.PrintUnit();
            }
        }
        void RenderStatic()
        {
            foreach (GameObject_Static static_go in Managers.SceneMgr.CurrentScene.staticSet)
            {
                static_go.PrintStatic();
            }
        }
        void RenderBG() //배경
        {
            RenderData RenderingData = Librarys.Find<Image>("BG1");
            Vector2Int pos = new Vector2Int(Define.ConsoleWidth / 2, Define.ConsoleHeight / 2);
            (RenderingData as Image).PrintImage(pos);
            // 아직 출력만
        }
        void RenderBuilder()
        {
            for (int y = 0; y < _builder.GetLength(0) - 1; y++)
            {
                _sb.AppendLine(new string(_builder[y]));
            }
            _sb.Append(new string(_builder[Console.WindowHeight - 1]));
            Console.Write(_sb);
        }
    }
}
