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
        public void Init()
        {
            //Test
            _sb = new StringBuilder();
            Console.CursorVisible = false;
            SetWindowSize();
            //Console.SetWindowSize(Console.LargestWindowWidth/2, (int)(Console.LargestWindowHeight * 0.8));
            //Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            _builder = new char[Console.WindowHeight][];
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                _builder[i] = new char[Console.WindowWidth];
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    _builder[i][j] = ' ';

                }
            }
        }
        void SetWindowSize()
        {
            try
            {
                Console.SetWindowSize(Define.ConsoleWidth, Define.ConsoleHeight);
                Console.SetBufferSize(Define.ConsoleWidth * 2, Define.ConsoleHeight);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("콘솔 글꼴 크기를 줄여주세요! (권장 6)");
                Console.SetCursorPosition(0, 0);
                SetWindowSize();
            }
        }
        void ClearConsole()
        {
            _sb.Clear();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                _builder[i] = new char[Console.WindowWidth];
                for (int j = 0; j < Console.WindowWidth; j++)
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
    }
}
