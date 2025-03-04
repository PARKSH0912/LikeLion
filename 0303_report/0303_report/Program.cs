using _0303_report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0303_report
{

    public class Player
    {

        public int player_Att;
        public int player_Hp;
        public bool player_Life = true;
        public int input;
        public int enemy_Hp;
        public int enemy_Att;
        public bool enemy_Life = true;
        public int Floor =1;
        public bool again = true;
        public int Drop_gold;
        public int gold;
        Random rand = new Random();

        public void Player_Stat(int hp,int att)
        {
            player_Hp = hp;
            player_Att = att;
        }

        public void Gold(int Drop_gold)
        {
            gold = Drop_gold;
        }


        public void MonsterRoom()
        {
            int enemy_Hp = rand.Next(5, 50) + (Floor / 2);
            int enemy_Att = rand.Next(1, 20) + (Floor / 2);
            while (enemy_Life)
            {
                Console.Clear();
                UI_Stat();
                Console.WriteLine("");
                Console.WriteLine($"몬스터 체력{enemy_Hp} | 몬스터 공격력 {enemy_Att}");
                Console.WriteLine("1. 싸운다");
                Console.WriteLine("2. 도망친다");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    enemy_Hp -= player_Att;
                    Console.WriteLine($"몬스터에게 공격! {player_Att}피해를 입혔습니다 몬스터의 남은 체력 {enemy_Hp}");
                    Thread.Sleep(500);

                    if (enemy_Hp > 0)
                    {

                        Console.WriteLine($"몬스터가 공격! {enemy_Att}만큼 피해를 입었습니다");
                        Thread.Sleep(500);
                        player_Hp -= enemy_Att;

                        if (player_Hp <= 0)
                        {
                            {
                                Console.Clear();
                                Console.WriteLine("플레이어가 사망했습니다.");
                                Thread.Sleep(500);
                                Environment.Exit(0);
                            }
                        }


                    }
                    else
                    {
                        Console.WriteLine("몬스터를 처치했습니다");
                        Thread.Sleep(500);
                        int Drop_gold = rand.Next(10, 100) + Floor;
                        Console.WriteLine($"골드 {Drop_gold}을 얻었습니다");
                        Thread.Sleep(500);
                        Gold(Drop_gold);
                        enemy_Life = false;
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(500);
                        Floor++;
                    }

                }

                else if (input == 2)
                {
                    int run = rand.Next(1, 101);
                    if (run <= 70)
                    {
                        Console.WriteLine("무사히 도망에 성공했습니다");
                        enemy_Life = false;
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(500);
                        Floor++;
                    }
                    else
                    {
                        Console.WriteLine($"{enemy_Att}의 피해를 입어 도망에 실패했습니다");
                        Thread.Sleep(500);
                        player_Hp -= enemy_Att;

                        if (player_Hp > 0)
                        {
                            Floor++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("플레이어가 사망했습니다.");
                            Thread.Sleep(500);
                            Environment.Exit(0);
                        }
 
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다");
                    Thread.Sleep(500);
                }
            }
        }

        public void BoxRoom()
        {
            Console.Clear();
            Console.WriteLine($"수상한 상자를 발견했습니다");
            Console.WriteLine("1. 열어본다");
            Console.WriteLine("2. 열지않는다");
            int box = rand.Next(1, 101);
            Thread.Sleep(500);
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                if (box <= 70)
                {
                    Console.WriteLine("좋은 느낌이 듭니다");
                    Thread.Sleep(500);
                    int weapon = rand.Next(1, 101);
                    if (weapon <= 2)
                    {
                        player_Att += 15;
                        Console.WriteLine("엑스칼리버 획득! 공격력 10증가");
                        Thread.Sleep(500);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(500);
                        Floor++;
                    }
                    else if (weapon <= 7)
                    {

                        player_Att += 10;
                        Console.WriteLine("요도 무라마사 획득! 공격력 7증가");
                        Thread.Sleep(500);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(500);
                        Floor++;

                    }
                    else if (weapon <= 15)
                    {
                        player_Att += 7;
                        Thread.Sleep(500);
                        Console.WriteLine("드워프제 검 획득! 공격력 3증가");
                        Thread.Sleep(500);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Floor++;
                    }
                    else if (weapon <= 50)
                    {
                        player_Att += 5;
                        Thread.Sleep(500);
                        Console.WriteLine(" 아직 쓸만한 검 획득! 공격력 2증가");
                        Thread.Sleep(500);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Floor++;
                    }
                    else if (weapon <= 70)
                    {
                        player_Att += 3;
                        Thread.Sleep(500);
                        Console.WriteLine(" 아직 쓸만한 검 획득! 공격력 2증가");
                        Thread.Sleep(500);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Floor++;
                    }
                    else
                    {
                        player_Att += 1;
                        Thread.Sleep(500);
                        Console.WriteLine("녹슨 검 획득 ! 공격력 1증가");
                        Thread.Sleep(500);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Floor++;
                    }
                }
                else if(box<=80)
                {

                    if (player_Hp <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("플레이어가 사망했습니다.");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("상자에서 독가스가 뿜어져 나옵니다");
                        Console.WriteLine($"{Floor}의 피해를 입습니다");
                        player_Hp -= Floor;
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(500);
                        Floor++;
                    }

                }
                else
                {

                    Console.WriteLine("상자가 비어있습니다");
                    Console.WriteLine("다음층으로 올라갑니다");
                    Thread.Sleep(500);
                    Floor++;
                }
            }
            else
            {
                Console.WriteLine("상자를 열지않았습니다");
                Thread.Sleep(500);
                Console.WriteLine("다음층으로 올라갑니다");
                Thread.Sleep(500);
                Floor++;
            }
        }

        public void EmptyRoom()
        {
            Console.Clear();
            Console.WriteLine($"텅 비어있는 방을 발견했습니다");
            Console.WriteLine("1. 휴식을 취한다");
            Console.WriteLine("2. 무기를 정비합니다");
            Console.WriteLine("3. 무기를 강화한다");
            Console.WriteLine("4. 탐색을 계속한다");
            Thread.Sleep(500);
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                player_Hp += Floor+10;
                Console.WriteLine($"휴식을 취합니다 {Floor+10}회복!");
                Console.WriteLine("다음층으로 올라갑니다");
                Thread.Sleep(500);
                Floor++;
            }
            else if (input == 2)
            {
                player_Att += 2;
                Console.WriteLine($"무기를 정비합니다 공격력 2 증가!");
                Console.WriteLine("다음층으로 올라갑니다");
                Thread.Sleep(500);
                Floor++;
            }
            else if (input == 3)
            {

                while (again)
                {
                    if (gold >= 100)
                    {
                        gold -= 100;
                        int grade = rand.Next(1, 101);

                        if (grade <= 30)
                        {
                            Console.Clear();
                            UI_Stat();
                            Thread.Sleep(500);
                            Console.WriteLine($"무기에 황금빛이 맴돕니다");
                            Console.WriteLine($"공격력 2증가");
                            player_Att += 4;
                            again = false;
                            Console.WriteLine("다음층으로 올라갑니다");
                            Thread.Sleep(500);
                            Floor++;
                        }
                        else
                        {
                            Console.Clear();
                            Thread.Sleep(500);
                            Console.WriteLine($"공격력 1증가");
                            player_Att += 2;

                            again = false;
                            Console.WriteLine("다음층으로 올라갑니다");
                            Thread.Sleep(500);
                            Floor++;
                        }

                    }
                    else
                    {
                        again = false;
                        Console.WriteLine("골드가 부족합니다");
                        Thread.Sleep(500);
                        Console.WriteLine("다음층으로 올라갑니다");
                        Thread.Sleep(500);
                        Floor++;
                    }
                }



            }
            else
            {
                Console.WriteLine("잘못된 입력입니다");
                Thread.Sleep(500);
            }
        }

        public void UI_Stat()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                            ┃");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine($"현재 상태 : 체력 {player_Hp} | 공격력 {player_Att} | 위치 {Floor}층 | 골드 {gold}");
            Console.SetCursorPosition(0, 2);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }

    }





    }

    class Program
    {
        static void Main(string[] args)
        {

        Console.CursorVisible = false;

        Console.SetWindowSize(80, 25);
        Console.SetBufferSize(80, 25);

        Player player = new Player();

        player.Player_Stat(100,10);

        while (player.player_Life)
        {
            Random rand = new Random();

            Console.Clear();
            player.UI_Stat();
            Console.WriteLine("\n1. 이동하시겠습니까?");
            Console.WriteLine("2. 휴식하겠습니까?");
            Console.WriteLine("3. 게임종료");
            Console.WriteLine("");

            int Main_input = int.Parse(Console.ReadLine());

            if(Main_input == 1)
            {
                player.enemy_Life = true;
                int go = rand.Next(1, 101);
                if (go <= 80) player.MonsterRoom();
                else if (go <= 90) player.BoxRoom();
                else player.EmptyRoom();

            }
            else if (Main_input == 2)
            {
                Console.Clear();
                player.player_Hp += player.Floor + 10;
                Console.WriteLine($"휴식을 취합니다 {player.Floor + 10}회복!");
                Console.WriteLine("다음층으로 올라갑니다");
                Thread.Sleep(1000);
                player.Floor++;
            }
            else if (Main_input == 3)
            {
                Console.Clear();
                Console.WriteLine("게임을 종료합니다 감사합니다");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("잘못 입력되었습니다 다시선택하세요");
                Thread.Sleep(1000);
            }
        }


    }
    }
