using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Script.Managers;

namespace SungSiKyung.Script.Rendering
{
    class PlayerPrint
    {
        // 이미지 배열
        static int[,] Idle1 = new int[14, 7] {{0,0,0,0,0,0,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,1,1,0,0},
                                              {0,1,0,1,0,1,0},
                                              {0,1,0,1,0,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,0,1,0,0},
                                              {0,1,0,0,0,1,0},
                                              {0,1,0,0,0,1,0},
                                              {0,0,0,0,0,0,0}};
        static int[,] Idle2 = new int[14, 7] {{0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,1,1,0,0},
                                              {0,1,0,1,0,1,0},
                                              {0,1,0,1,0,1,0},
                                              {0,0,1,0,1,0,0},
                                              {0,1,0,0,0,1,0},
                                              {0,1,0,0,0,1,0},
                                              {0,0,0,0,0,0,0}};
        static int[,] Move1 = new int[14, 7]  {{0,0,0,0,0,0,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,1,1,0,0},
                                              {0,1,0,1,0,1,1},
                                              {0,1,0,1,0,0,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,0,1,0,0},
                                              {1,1,0,0,0,1,0},
                                              {0,0,0,0,0,1,0},
                                              {0,0,0,0,0,0,0}};
        static int[,] Move2 = new int[14, 7]  {{0,0,0,0,0,0,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,1,1,0,0},
                                              {0,1,0,1,1,0,0},
                                              {0,0,1,1,0,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,0,1,0,0},
                                              {0,0,1,0,1,0,0},
                                              {0,1,0,0,1,0,0},
                                              {0,0,0,0,0,0,0}};
        static int[,] Jump1 = new int[14, 7] {{0,0,0,0,0,0,0},
                                              {0,0,0,0,0,0,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,1,1,0,0},
                                              {0,1,0,1,0,1,0},
                                              {0,1,0,1,0,1,0},
                                              {0,0,1,0,1,0,0},
                                              {0,1,0,0,0,1,0},
                                              {0,1,0,0,0,1,0},
                                              {0,0,0,0,0,0,0}};
        static int[,] Jump2 = new int[14, 7] {{0,0,0,0,0,0,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,1,1,1,1,0},
                                              {0,0,0,1,0,0,0},
                                              {0,1,1,1,1,1,0},
                                              {1,0,0,1,0,0,1},
                                              {0,0,0,1,0,0,0},
                                              {0,0,0,1,0,0,0},
                                              {0,0,1,0,1,1,0},
                                              {0,0,1,0,0,1,0},
                                              {0,0,1,0,0,0,0},
                                              {0,0,0,0,0,0,0}};
        /*
        static int[,] Lie1 = new int[7, 14] {{0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {0,0,0,0,0,0,0,0,0,1,1,1,1,0},
                                            {0,0,0,0,1,1,1,1,1,1,1,1,1,0},
                                            {0,0,0,0,1,0,0,1,0,1,1,1,1,0},
                                            {0,0,1,1,1,0,0,1,0,1,1,1,1,0},
                                            {0,0,0,0,0,0,0,0,0,0,0,0,0,0}};
        */

        static int idleState = 1;
        static int moveState = 1;
        static int stateTick = 0;
        static int X, Y;
        static int dir;

        public static void State(int _stateNum, int _X, int _Y, int _dir) // 이것만 호출하면 됩니다!
        {
            X = _X;
            Y = _Y;
            dir = _dir;
            PlayerClear(_stateNum);
            switch (_stateNum)
            {
                case 0:
                    Idle();
                    break;
                case 1:
                    Move();
                    break;
                case 2:
                    Jump();
                    break;
            }
        }

        static void Idle()
        {
            if (idleState == 1)
            {
                IdlePrint1();
            }
            else
            {
                IdlePrint2();
            }

            if (Environment.TickCount - stateTick >= 300) //30프레임으로 끄덕이면 안돼서
            {
                idleState *= -1;
                stateTick = Environment.TickCount;
            }
        }
        static void Move()
        {
            if (moveState == 1)
            {
                MovePrint1();
            }
            else
            {
                MovePrint2();
            }

            if (Environment.TickCount - stateTick >= 300) //30프레임으로 움직이면 안돼서
            {
                moveState *= -1;
                stateTick = Environment.TickCount;
            }
        }
        static void Jump() // 아직 미구현
        {

        }

        public static void IdlePrint1()
        {
            PrintFor(Idle1);
        }
        public static void IdlePrint2()
        {
            PrintFor(Idle2);
        }
        public static void MovePrint1()
        {
            PrintFor(Move1);
        }
        public static void MovePrint2()
        {
            PrintFor(Move2);
        }

        public static void PlayerClear(int n)
        {
            int x = ReturnX(X);
            int y = ReturnY(Y);
            int xLength = 0, yLength = 0;
            switch (n)
            {
                case 0:
                    xLength = Idle1.GetLength(1);
                    yLength = Idle2.GetLength(0);
                    break;
                case 1:
                    xLength = Move1.GetLength(1);
                    yLength = Move2.GetLength(0);
                    break;
            }

            if (dir == 1)
            {
                for (int i = 0; i < yLength; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ");
                    y++;
                }
            }
            else
            {
                x = x + ((xLength - 1) * 2);
                for (int i = 0; i < yLength; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ");
                    y++;
                }
            }
        }

        static void PrintFor(int [,] _arr)
        {
            int x = ReturnX(X);
            int y = ReturnY(Y);
            int xLength = _arr.GetLength(1);
            int yLength = _arr.GetLength(0);
            if (dir == 1)
            {
                for (int i = 0; i < yLength; i++)
                {
                    Console.SetCursorPosition(x, y);
                    for (int j = 0; j < xLength; j++)
                    {
                        if (_arr[i, j] == 1)
                            Console.Write("■");
                        else
                            Console.Write("  ");
                    }
                    y++;
                }
            }
            else
            {
                for (int i = 0; i < yLength; i++)
                {
                    Console.SetCursorPosition(x, y);
                    for (int j = xLength; j > 0; j--)
                    {
                        if (_arr[i, j - 1] == 1)
                            Console.Write("■");
                        else
                            Console.Write("  ");
                    }
                    y++;
                }
            }
        }

        // 중심 (0,0)에서 왼쪽 상단 (0,0)으로 변환
        static int ReturnX(int _X)
        {
            return _X + 80; // 콘솔창 X크기 / 2
        }
        static int ReturnY(int _Y)
        {
            return 23 - _Y; // 콘솔창 Y크기 / 2
        }
    }
}