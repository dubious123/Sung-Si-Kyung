using SungSiKyung.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using SungSiKyung.Data;

namespace SungSiKyung.Script.Managers
{
    public class RenderingManager
    {
        //    [DllImport("")]
        //    static extern IntPtr GetConsoleWindow();
        StringBuilder _builder;
        public void Init()
        {
            //Test
            Console.CursorVisible = false;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            _builder = new StringBuilder();
            
        }
        void ClearConsole()
        {
            Console.Clear();
        }
        public void RenderScene()
        {
            ClearConsole();
            RenderDynamic();
           
        }
        void RenderDynamic()
        {
            foreach (GameObject go in Managers.SceneMgr.CurrentScene.unitSet)
            {
                //Todo
                //foreach(Vector2 delta in go.image){print}
                Console.SetCursorPosition((int)go.Transform.Position.x,(int)go.Transform.Position.y);
                Console.WriteLine("@@@@@");
                Console.WriteLine("@@@@@");
                Console.WriteLine("@@@@@");
                Console.WriteLine("@@@@@");
            }
        }
    }
}
