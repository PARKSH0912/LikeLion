using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame
{
    class Program
    {
        struct Player
        {
            public int X, Y;
            public string[] Shape;

            public Player(int x, int y)
            {
                X = x;
                Y = y;
                Shape = new string[]
                {
                "■■▶",
                "■■■■▶",
                "■■▶"
                };
            }

            public void Move(ConsoleKey key)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow: if (Y > 0) Y--; break;
                    case ConsoleKey.DownArrow: if (Y < Console.WindowHeight - Shape.Length) Y++; break;
                    case ConsoleKey.LeftArrow: if (X > 0) X--; break;
                    case ConsoleKey.Spacebar: Console.Write("★☆★☆★☆"); break;
                    case ConsoleKey.RightArrow: if (X < Console.WindowWidth - 3) X++; break;
                }
            }

            public void Draw()
            {
                for (int i = 0; i < Shape.Length; i++)
                {
                    Console.SetCursorPosition(X, Y + i);
                    Console.Write(Shape[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            int width = Math.Min(80, Console.LargestWindowWidth);
            int height = Math.Min(25, Console.LargestWindowHeight);
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            Console.CursorVisible = false;

            Player player = new Player(0, 12);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            long prevSecond = timer.ElapsedMilliseconds;

            while (true)
            {
                long currentSecond = timer.ElapsedMilliseconds;

                if (currentSecond - prevSecond >= 100)
                {
                    Console.Clear();
                    prevSecond = currentSecond;
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else
                        {
                            player.Move(keyInfo.Key);
                        }
                    }
                    player.Draw();

                    Thread.Sleep(50);
                }
            }
        }
    }
}