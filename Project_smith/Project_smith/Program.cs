﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_smith
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500); // 0.5초 

            //무한반복 
            while (true)
            {
                Console.Clear(); // 화면 지우기 
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기  ");
                Console.Write("입력: ");
                input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

                if (input == 1)
                {
                    Console.WriteLine("나무캐기 (엔터)");
                    Console.WriteLine("뒤로가기 x");
                    string str = Console.ReadLine();

                    pmoney += 1000;
                    Console.WriteLine("소지금액 : " + pmoney);

                    if (str == "x")
                    {
                        Console.WriteLine("뒤로가기");
                        break;
                    }

                }
                else if (input == 2)
                {
                    //장비 뽑기 
                    if (pmoney >= 1000) // 돈 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;

                        //20번 뽑기 

                        for (int i = 1; i < 20; i++)
                        {
                            rnd = rand.Next(1, 101);
                            if (rnd == 1) // 1퍼
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼 등급 A");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("도끼 등급 B");
                            }
                            else if (rnd >= 70 && rnd <= 100)
                            {
                                Console.WriteLine("도끼 등급 C");
                            }
                            Thread.Sleep(500); //0.5초
                        }


                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다\n");
                        Thread.Sleep(1000);
                    }

                }
                else if (input ==3)
                {
                    Console.WriteLine("나갑니다");
                    Environment.Exit(0);
                }
            }
        }
    }
}
