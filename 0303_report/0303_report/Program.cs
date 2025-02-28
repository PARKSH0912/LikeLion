using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0303_report
{
    public class Player
    {
        public int player_Att = 10;
        public int player_Hp =100;
        public bool player_Life = false;
        public int input;

    }
    public class Room
    {
        public int enemy_Hp;
        public int enemy_Att;
        public bool enemy_Life = true;

        public int Gold;
        public int Floor =1;

        public void Drop()
        {
            Random rand = new Random();
            int rand_gold = rand.Next(10,100);
            double total_gold = rand_gold * (1+0.1 * Floor);
        }

        public void MonsterRoom()
        {
            while (enemy_Life)
            {
                Console.WriteLine($"몬스터를 만났습니다! 몬스터 체력{mob_Health} | 몬스터 공격력 {mob_att}");
                Console.WriteLine("1. 싸운다");
                Console.WriteLine("2. 도망친다");

                if (input == 1)
                {
                    enemy_Hp -= player_Att;
                    Console.WriteLine($"몬스터에게 공격! {player_Att}피해를 입혔습니다 몬스터의 남은 체력 {enemy_Hp}");
                    Thread.Sleep(1000);

                    if (enemy_Hp > 0)
                    {
                        Console.WriteLine($"몬스터가 공격! {enemy_Att}만큼 피해를 입었습니다");
                        Thread.Sleep(1000);
                        player_Hp -= enemy_Att;
                    }
                    else
                    {
                        Console.WriteLine("몬스터를 처치했습니다");
                        Thread.Sleep(1000);
                        Console.WriteLine($"골드 {total_gold}을 얻었습니다");
                        Gold += total_gold;
                        Thread.Sleep(1000);
                        enemy_Life = false;
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(1000);
                        Floor++;
                    }
                }

                else if (input == 2)
                {
                    Random rand = new Random();
                    int run = rand.Next(1, 101);
                    if (run <= 70)
                    {
                        Console.WriteLine("무사히 도망에 성공했습니다");
                        enemy_Life = false;
                        Console.WriteLine("다음층으로 올라갑니다");
                        Floor++;
                    }
                    else
                    {
                        Console.WriteLine($"{mob_att}의 피해를 입어 도망에 실패했습니다");
                        player_Hp -= enemy_Att;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다");
                }
            }
        }

        public void BoxRoom()
        {

        }





    }

    public class Item
    {

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int att = 10;
            int health = 100;
            int input;
            int location = 1;
            bool isAlive = true;
            bool mob_Alive = true;

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 상태 : 체력 {health} | 공격력 {att} | 위치 {location}층");
                Console.WriteLine("\n1. 이동하시겠습니까?");
                Console.WriteLine("2. 휴식하겠습니까?");
                Console.WriteLine("3. 게임종료");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 30)
                    {
                        int mob_Health = rand.Next(5, 15);
                        int mob_att = rand.Next(5, 15);
                        Console.WriteLine($"몬스터를 만났습니다! 몬스터 체력{mob_Health} | 몬스터 공격력 {mob_att}");
                        Console.WriteLine("1. 싸운다");
                        Console.WriteLine("2. 도망친다");

                        int input2 = int.Parse(Console.ReadLine());
                        if (input2 == 1)
                        {
                            while (mob_Alive)
                            {
                                mob_Health = mob_Health - att;
                                Console.WriteLine($"몬스터에게 공격! {att}피해를 입혔습니다 몬스터의 남은 체력 {mob_Health}");
                                Thread.Sleep(1000);
                                if (mob_Health > 0)
                                {
                                    Console.WriteLine($"몬스터가 공격! {mob_att}만큼 피해를 입었습니다");
                                    Thread.Sleep(1000);
                                    health -= mob_att;
                                }
                                else
                                {
                                    Console.WriteLine("몬스터를 처치했습니다");
                                    Thread.Sleep(1000);
                                    mob_Alive = false;
                                    Console.WriteLine("다음층으로 올라갑니다");
                                    Thread.Sleep(1000);
                                    location++;
                                }

                            }

                        }
                        else if (input2 == 2)
                        {
                            int run = rand.Next(1, 101);
                            if (run <= 70)
                            {
                                Console.WriteLine("무사히 도망에 성공했습니다");
                                Console.WriteLine("다음층으로 올라갑니다");
                                location++;
                            }
                            else
                            {
                                Console.WriteLine($"{mob_att}의 피해를 입었으나 도망에 성공했습니다");
                                Console.WriteLine("다음층으로 올라갑니다");
                                health -= mob_att;
                                location++;
                            }
                        }
                    }
                    else if (eventChance <= 80)
                    {
                        Console.WriteLine("상자를 발견했습니다");
                        Console.WriteLine("1.열어본다  |  2.무시한다.");

                        int input_2 = int.Parse(Console.ReadLine());

                        if (input_2 == 1)
                        {
                            int box = rand.Next(1, 101);

                            if (box <= 70)
                            {
                                Console.WriteLine("좋은 느낌이 듭니다");
                                Thread.Sleep(1000);
                                int weapon = rand.Next(1, 101);
                                if (weapon <= 1)
                                {
                                    att += 10;
                                    Console.WriteLine("엑스칼리버 획득! 공격력 10증가");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("다음층으로 올라갑니다");
                                    Thread.Sleep(1000);
                                    location++;
                                }
                                else if (weapon <= 5)
                                {

                                    att += 5;
                                    Console.WriteLine("요도 무라마사 획득! 공격력 7증가");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("다음층으로 올라갑니다");
                                    Thread.Sleep(1000);
                                    location++;

                                }
                                else if (weapon <= 10)
                                {
                                    att += 3;
                                    Thread.Sleep(1000);
                                    Console.WriteLine("드워프제 검 획득! 공격력 3증가");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("다음층으로 올라갑니다");
                                    location++;
                                }
                                else
                                {
                                    att += 1;
                                    Thread.Sleep(1000);
                                    Console.WriteLine("녹슨 검 획득 ! 공격력 1증가");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("다음층으로 올라갑니다");
                                    location++;
                                }
                            }
                            else
                            {

                                Console.WriteLine("상자가 비어있습니다");
                                Thread.Sleep(1000);
                                Console.WriteLine("다음층으로 올라갑니다");
                                Thread.Sleep(1000);
                                location++;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("아무런일이 일어나지않았습니다");
                        Thread.Sleep(1000);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(1000);
                        location++;
                    }

                }
                else if (input == 2)
                {
                    int rest = rand.Next(1, 101);
                    location++;

                    if (rest <= 70)
                    {
                        health += 15;
                        Console.WriteLine($"휴식을 취합니다 15회복!");
                        Thread.Sleep(1000);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(1000);
                    }
                    else
                    {

                        int mob_Health = rand.Next(5, 15);
                        int mob_att = rand.Next(5, 15);
                        Console.WriteLine($"몬스터를 만났습니다! 몬스터 체력{mob_Health} | 몬스터 공격력 {mob_att}");
                        Console.WriteLine("1. 싸운다");
                        Console.WriteLine("2. 도망친다");

                        int input2 = int.Parse(Console.ReadLine());
                        if (input2 == 1)
                        {
                            while (mob_Alive)
                            {
                                mob_Health = mob_Health - att;
                                Console.WriteLine($"몬스터에게 공격! {att}피해를 입혔습니다 몬스터의 남은 체력 {mob_Health}");
                                Thread.Sleep(1000);
                                if (mob_Health > 0)
                                {
                                    Console.WriteLine($"몬스터가 공격! {mob_att}만큼 피해를 입었습니다");
                                    Thread.Sleep(1000);
                                    health -= mob_att;
                                }
                                else
                                {
                                    Console.WriteLine("몬스터를 처치했습니다");
                                    Thread.Sleep(1000);
                                    mob_Alive = false;
                                    Console.WriteLine("다음층으로 올라갑니다");
                                    Thread.Sleep(1000);
                                    location++;
                                }
                            }

                        }

                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("게임을 종료합니다 감사합니다");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("잘못 입력되었습니다 다시선택하세요");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}