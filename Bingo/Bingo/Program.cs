using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[25];


            //for (int i = 0; i < 25; i++)
            //{
            //    iArray[i] = i + 1;
            //}

            ////for (int i = 0; i < 5; i++)
            ////{
            ////    for (int j = 0; j < 5; j++)
            ////    {
            ////        Console.Write(iArray[i].ToString("D2") + " ");
            ////    }
            ////    Console.WriteLine();
            ////}
            //// 셔플
            //Random rand = new Random();

            //for(int i=0; i<100; i++)
            //{
            //    int iA = rand.Next(0, 25);
            //    int iB = rand.Next(0, 25);
            //    int iT = 0;

            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;

            //}

            //int input = 0;
            //int icount = 0;
            //int iBingo = 0;


            //while (true)
            //{
            //    Console.Clear();
            //    //빙고판 
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0) //0일 경우 체크 
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("빙고 숫자 : " + iBingo);
            //    Console.WriteLine("숫자를 입력하세요: ");
            //    input = int.Parse(Console.ReadLine());
            //    iBingo = 0;

            //    for(int i=0; i<25; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }

            //    // 빙고 체크 로직
            //    // 가로 체크 로직

            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                ++icount;
            //            }
            //            if (icount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        icount = 0;
            //    }


            //    // 세로 체크

            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i + 5 * j] == 0)
            //            {
            //                ++icount;
            //            }
            //            if (icount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        icount = 0;
            //    }


            //    //대각선 오른쪽체크
            //    //00 01 02 03 04 
            //    //05 06 07 08 09 
            //    //10 11 12 13 14
            //    //15 16 17 18 19
            //    //20 21 22 23 24

            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 4 + 4] == 0)
            //        {
            //            ++icount;
            //        }
            //        if (icount == 5)
            //        {
            //            ++icount;
            //        }
            //    }
            //    icount = 0;

            //    //대각선 왼쪽체크
            //    //00 01 02 03 04 
            //    //05 06 07 08 09 
            //    //10 11 12 13 14
            //    //15 16 17 18 19
            //    //20 21 22 23 24

            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 6] == 0)
            //        {
            //            ++icount;
            //        }
            //        if (icount == 5)
            //        {
            //            ++icount;
            //        }
            //    }

            //    icount = 0;

            //    if (iBingo >= 5)
            //    {
            //        Console.WriteLine("빙고 성공");
            //        break;
            //    }

            //}

            int[,] board = new int[5, 5]; //5*5빙고판
            bool[,] marked = new bool[5, 5]; //선택된 숫자체크 

            int bingoCount = 0;
            Random rand = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i =0; i<25; i++)
            {
                numbers[i] = i + 1;
            }
            
            //랜덤섞기
            for (int i = 0; i<100; i++)
            {
                int a = rand.Next(25);
                int b = rand.Next(25);

                // C#의 튜플 문법을 활용하여 두 변수의 값을 교환하는 방법 
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }

            //2차열 배열로 변환
            int index = 0;
            for(int i =0; i<5; i++)
            {
                for(int j =0; j<5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }
            //게임시작
            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");

                for(int i =0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (marked[i, j])
                        {
                            Console.Write(" X ");
                        }
                        else
                        {
                            Console.Write($"{board[i, j],2} ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());

                bool found = false;

                for(int i=0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (board[i,j] == number)
                        {
                            marked[i, j] = true; //숫자를 x로 변경
                            break;
                        }
                    }
                    if (found)
                        break;
                }
                //빙고 개수 체크
                bingoCount = 0;

                //r가로체크
                for(int i=0; i<5; i++)
                {
                    bool rowBingo = true;
                    for(int j=0; j<5; j++)
                    {
                        if (!marked[i, j])
                        {
                            rowBingo = false;
                        }
                    }
                    if (rowBingo)
                    {
                        bingoCount++;
                    }
                }

                //세로 체크

                for(int j=0; j<5; j++)
                {
                    bool colBingo = true;
                    for (int i =0; i<5; i++)
                    {
                        if (!marked[i,j])
                        {
                            colBingo = false;
                        }
                    }
                    if (colBingo)
                    {
                        bingoCount++;
                    }
                }

                //대각선체크 (왼쪽위 -> 오른쪽아래_

                bool diag1Bingo = true;

                for(int i=0; i<5; i++)
                {
                    if (!marked[i, i])
                    {
                        diag1Bingo = false;
                    }
                }
                if (diag1Bingo)
                {
                    bingoCount++;
                }

                bool diag2Bingo = true;

                for (int i=0; i<5; i++)
                {
                    if (!marked[i, 4 - i])
                    {
                        diag2Bingo = false;
                    }
                }
                if (diag2Bingo)
                {
                    bingoCount++;
                }

                Console.WriteLine("빙고 5개 완성! 게임종료");
            }

        }
    }
}
