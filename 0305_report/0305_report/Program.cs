using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0305_report
{
    class Champion
    {
        public string Name;
        public int Attack;
        public int Magic_Attack;

        public Champion()
        {
            Name = "Unknwon";
            Attack = 0;
            Magic_Attack = 0;
        }

        public virtual void Noraml_Attack()
        {
            Console.WriteLine($"{Name}이(가) 공격합니다");
            Thread.Sleep(500);
        }
        public virtual void Use_Skill()
        {
            Console.WriteLine($"{Name}이(가) 스킬을 사용합니다");
            Thread.Sleep(500);
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다. ");
            Thread.Sleep(500);
        }

    }
    class Bard : Champion   
    {
        public Bard()
        {
            Name = "Bard";
            Attack = 52;
            Magic_Attack = 0;
        }
        public override void Noraml_Attack()
        {
            Console.WriteLine($"{Name}이(가) 공격합니다");
            Thread.Sleep(500);
        }
        public override void Use_Skill()
        {
            Console.WriteLine($"{Name}이(가) 스킬을 사용합니다");
            Thread.Sleep(500);
        }

        public override void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다. ");
            Thread.Sleep(500);
        }

    }



    class Skill : Bard   
    {
        public string Skill_Name;
        public int ManaCost;
        public int Cooldown;
        public int LastUsedTime;

        public Skill(string name, int manaCost, int cooldown)
        {
            Skill_Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown*1000;
            LastUsedTime = 0;
        }
        public bool Canuse(int playerMana)
        {
            int currentTime = Environment.TickCount;

            if (playerMana < ManaCost)
            {
                Console.WriteLine($"마나가 부족합니다! (필요 MP : {ManaCost}");
                return false;
            }

            if (currentTime - LastUsedTime < Cooldown)
            {
                int reaminingTIme = (Cooldown - (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($"{Name}스킬은 아직 사용할수 없습니다. 남은시간 : {reaminingTIme}");
                return false;
            }

            return true;
        }

        public void Use(ref int playerMana)
        {
            if (!Canuse(playerMana)) return;
            playerMana -= ManaCost;                 //플레이어 마나 참조로 외부값도 같이 조정 동기화 
            LastUsedTime = Environment.TickCount;   //현재시간을 저장 

            Console.WriteLine($"{Name} 스킬 사용! MP - {ManaCost}");
        }

        public void Use_Skill()
        {
            Skill[] skills = new Skill[]
            {
                new Skill("우주의 결속",60,11),
                new Skill("수호자의 성소",70,18),
                new Skill("신비한 차원문",30,22),
                new Skill("운명의 소용돌이",110,100)
            };



        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            int playerMana = 2000;

            Bard bard = new Bard();


            Skill[] skills = new Skill[]
            {
                new Skill("우주의 결속",60,11),
                new Skill("수호자의 성소",70,18),
                new Skill("신비한 차원문",30,22),
                new Skill("운명의 소용돌이",110,100)
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"챔피언 이름 : {bard.Name} | 현재 MP : {playerMana}");
                Console.WriteLine("1. 공격한다");
                Console.WriteLine("2. 스킬을 사용한다");
                Console.WriteLine("3. 이동한다");
                Console.WriteLine("0. 종료한다");
                Console.WriteLine("");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (input == 0)
                {
                    Console.WriteLine("게임종료");
                    break;
                }
                else if (input == 1)
                {
                    bard.Noraml_Attack();
                }
                else if (input == 2)
                {
                    bard.Use_Skill();

                    Console.WriteLine("사용 가능한 스킬: ");
                    for (int i = 0; i < skills.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}.{skills[i].Skill_Name} MP {skills[i].ManaCost} " + $"쿨다운 {skills[i].Cooldown / 1000}s");
                    }
                    Console.WriteLine("0. 종료");
                    Console.WriteLine("사용할 스킬 번호를 입력하세요");


                    try
                    {
                        int skillIndex = int.Parse(Console.ReadLine());

                        if (skillIndex == 0) break;

                        if (skillIndex > 0 && skillIndex <= skills.Length)
                        {
                            skills[skillIndex - 1].Use(ref playerMana);
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("숫자를 입력하세요");
                    }
                    Thread.Sleep(5000); //cpu 과부화 방지
                }
                else if (input == 3)
                {
                    bard.Move();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다");
                }
            }

        }

    }
    
}
