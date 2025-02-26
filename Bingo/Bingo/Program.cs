using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[25];


            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(iArray[i].ToString("D2") + " ");
            //    }
            //    Console.WriteLine();
            //}
            // 셔플
            Random rand = new Random();

            for(int i=0; i<100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;

                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
                
            }

            int input = 0;
            int icount = 0;
            int iBingo = 0;


            while (true)
            {
                Console.Clear();
                //빙고판 
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0) //0일 경우 체크 
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("빙고 숫자 : " + iBingo);
                Console.WriteLine("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;

                for(int i=0; i<25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }

                // 빙고 체크 로직
                // 가로 체크 로직

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            ++icount;
                        }
                        if (icount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    icount = 0;
                }


                // 세로 체크

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i + 5 * j] == 0)
                        {
                            ++icount;
                        }
                        if (icount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    icount = 0;
                }


                //대각선 오른쪽체크
                //00 01 02 03 04 
                //05 06 07 08 09 
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24

                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 4 + 4] == 0)
                    {
                        ++icount;
                    }
                    if (icount == 5)
                    {
                        ++icount;
                    }
                }
                icount = 0;

                //대각선 왼쪽체크
                //00 01 02 03 04 
                //05 06 07 08 09 
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24

                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0)
                    {
                        ++icount;
                    }
                    if (icount == 5)
                    {
                        ++icount;
                    }
                }

                icount = 0;

                if (iBingo >= 5)
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }

            }
        }
    }
}
