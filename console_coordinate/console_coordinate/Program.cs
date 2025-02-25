using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace console_coordinate
{
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 창 크기 섲렁
            Console.SetWindowSize(80, 25); //x 80 ,y 25

            // 콘솔 버프 크기도 설정
            Console.SetBufferSize(80, 25);


            Console.WriteLine("콘솔 창 크기가 80x25설정되었습니다");

            Console.CursorVisible = false; //커서 숨기기

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("┃                                      ┃");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("┃                                      ┃");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("┃                                      ┃");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("┃          대장장이 키우기             ┃");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("┃                                      ┃");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("┃                                      ┃");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("┃                                      ┃");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("┃                                      ┃");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.SetCursorPosition(0, 10);

            Thread.Sleep(3000);
            Console.Clear();


            for(int x= 0; x<30; x++) //0~29이동
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("◎");
                Thread.Sleep(100);

            }



        }
    }
}
