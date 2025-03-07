using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0307_Test
{
    public class Fight
    {
        Player player = new Player();
        Monster monster = new Monster();
        Info info = new Info();

        public void Fight_Start()
        {
            while (true)
            {

                Console.WriteLine("1. 공격한다");
                Console.WriteLine("2. 도망간다");

                int iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    Console.WriteLine("전투 시작");

                    if(> 0)
                    {
                        Console.WriteLine("몬스터 사망");
                    }
                    else
                    {
                        Console.WriteLine("플레이어 사망");
                    }

                    Console.WriteLine("전투 종료");
                }
                else if (iInput == 2)
                {
                    Console.WriteLine("도망갑니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                }
            }

        }
    }
}
