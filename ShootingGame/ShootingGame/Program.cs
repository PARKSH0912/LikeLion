using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Console.WriteLine("콘솔 창 크기가 80x25로 설정되었습니다.");
            Console.ReadKey(); // 키 입력 대기

            //int x = 10, y = 10;
            //ConsoleKeyInfo keyInfo;

            //Console.CursorVisible = false;

            //while (true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("●"); // 현재 위치 출력

            //    keyInfo = Console.ReadKey(true); //키 입력받기(화면출력X)

            //    //방향키 입력에 따른 좌표 변경

            //    switch (keyInfo.Key) 
            //    {
            //        case ConsoleKey.UpArrow: if (y > 0) y--;break;
            //        case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //        case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //        case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //        case ConsoleKey.Escape: return;


            //    }


            string[] player = new string[] 
            { 
            
                "->",
                ">>>",
                "->",  
            }; //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1000 = 1s

            


            while (true)
            {

                long currendSecond = stopwatch.ElapsedMilliseconds; //현재시간가져오기

                if(currendSecond - prevSecond >= 100)
                {
                    Console.WriteLine("1초루프");

                    Console.Clear();
                    prevSecond = currendSecond;//이전시간업데이트 

                    keyInfo = Console.ReadKey(true); //키 입력받기(화면출력X)

                    //방향키 입력에 따른 좌표 변경

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return;


                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }
                    Thread.Sleep(100);
                    Console.Clear();
                }


            }

        }


    
    }
}

s