using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shootinggmae2
{
    public class BULLTE
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX; //플레이어X좌표
        public int playerY; //플레이어Y좌표
        public BULLTE[] playerBullet = new BULLTE[20];
        public BULLTE[] playerBullet2 = new BULLTE[20];
        public BULLTE[] playerBullet3 = new BULLTE[20];
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;



        public Player() //생성자
        {
            //플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 12;
            for (int i = 0; i < 20; i++)//총알 초기화
            {
                playerBullet[i] = new BULLTE();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLTE();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLTE();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();

            //플레이어를 그려준다.
            PlayerDraw();

            //Ui점수
            UIscore();

            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }

        }

        public void KeyControl()
        {
            int pressKey; //정수형 변수 선언 키값 받을거임
            if (Console.KeyAvailable) // 키가 눌렸을떄 True
            {
                pressKey = _getch(); //아스키값왼쪽 오른쪽 

                switch (pressKey)
                {
                    case 72: //위쪽방향 아스키코드 
                        {
                            playerY--;
                            if (playerY < 1)
                            {
                                playerY = 1;
                            }
                            break;
                        }
                    case 75: //왼쪽 화살표키
                        {
                            playerX--;
                            if (playerX < 1)
                            {
                                playerX = 1;
                            }
                            break;
                        }
                    case 77: //오른쪽 키
                        {
                            playerX++;
                            if (playerX > 75)
                            {
                                {
                                    playerX = 75;
                                }
                            }
                            break;
                        }
                    case 80: //아래
                        {
                            playerY++;
                            if (playerY > 22)
                            {
                                playerY = 22;
                            }
                            break;

                        }
                    case 32://스페이스바
                        {
                            //총알 발사
                            for (int i = 0; i < 20; i++)
                            {
                                if (playerBullet[i].fire == false)
                                {
                                    playerBullet[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 +5
                                    playerBullet[i].x = playerX + 5;
                                    playerBullet[i].y = playerY + 1;
                                    //한발씩 쏘겠다.
                                    break;

                                }
                            }

                            //총알 발사
                            for (int i = 0; i < 20; i++)
                            {
                                if (playerBullet2[i].fire == false)
                                {
                                    playerBullet2[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 +5
                                    playerBullet2[i].x = playerX + 5;
                                    playerBullet2[i].y = playerY + 2;
                                    //한발씩 쏘겠다.
                                    break;

                                }
                            }

                            //총알 발사
                            for (int i = 0; i < 20; i++)
                            {
                                if (playerBullet3[i].fire == false)
                                {
                                    playerBullet3[i].fire = true;
                                    //플레이어 앞에서 미사일 쏘기 +5
                                    playerBullet3[i].x = playerX + 5;
                                    playerBullet3[i].y = playerY;
                                    //한발씩 쏘겠다.
                                    break;

                                }
                            }
                        }
                        break;

                }


            }


        }

        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->"; //미사일모습 
            string S_bullet = "-333";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    if ((i+1) % 3 == 0)
                    {
                        //좌표설정 -> 중간위치를 위해 보정 x-1 
                        Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);

                        //총알 출력
                        Console.Write(S_bullet);

                        playerBullet[i].x++; //미사일은 오른쪽으로 날라가기 

                        if (playerBullet[i].x > 79)
                        {
                            playerBullet[i].fire = false; //미사일 false 다시 준비상태
                        }
                    }
                    else
                    {
                        //좌표설정 -> 중간위치를 위해 보정 x-1 
                        Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);

                        //총알 출력
                        Console.Write(bullet);

                        playerBullet[i].x++; //미사일은 오른쪽으로 날라가기 

                        if (playerBullet[i].x > 79)
                        {
                            playerBullet[i].fire = false; //미사일 false 다시 준비상태
                        }
                    }
                }
            }

        }

        public void BulletDraw2()
        {
            string bullet = "->"; //미사일모습 
            string S_bullet = "-★";


            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    if ((i + 1) % 3 == 0)
                    {
                        //좌표설정 -> 중간위치를 위해 보정 x-1 
                        Console.SetCursorPosition(playerBullet2[i].x, playerBullet2[i].y);

                        //총알 출력
                        Console.Write(S_bullet);

                        playerBullet2[i].x++; //미사일은 오른쪽으로 날라가기 

                        if (playerBullet2[i].x > 79)
                        {
                            playerBullet2[i].fire = false; //미사일 false 다시 준비상태
                        }
                    }
                    else
                    {
                        //좌표설정 -> 중간위치를 위해 보정 x-1 
                        Console.SetCursorPosition(playerBullet2[i].x, playerBullet2[i].y);

                        //총알 출력
                        Console.Write(bullet);

                        playerBullet2[i].x++; //미사일은 오른쪽으로 날라가기 

                        if (playerBullet2[i].x > 79)
                        {
                            playerBullet2[i].fire = false; //미사일 false 다시 준비상태
                        }
                    }
                }
            }

        }
        public void BulletDraw3()
        {
            string bullet = "->"; //미사일모습 
            string S_bullet = "-☆"; 


            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    if ((i + 1) % 3 == 0)
                    {
                        //좌표설정 -> 중간위치를 위해 보정 x-1 
                        Console.SetCursorPosition(playerBullet3[i].x, playerBullet3[i].y);

                        //총알 출력
                        Console.Write(S_bullet);

                        playerBullet3[i].x++; //미사일은 오른쪽으로 날라가기 

                        if (playerBullet3[i].x > 79)
                        {
                            playerBullet3[i].fire = false; //미사일 false 다시 준비상태
                        }
                    }
                    else
                    {
                        //좌표설정 -> 중간위치를 위해 보정 x-1 
                        Console.SetCursorPosition(playerBullet3[i].x, playerBullet3[i].y);

                        //총알 출력
                        Console.Write(bullet);

                        playerBullet3[i].x++; //미사일은 오른쪽으로 날라가기 

                        if (playerBullet3[i].x > 79)
                        {
                            playerBullet3[i].fire = false; //미사일 false 다시 준비상태
                        }
                    }
                }
            }

        }

        public void PlayerDraw()
        {
            string[] player = new string[]

            {
                "■>",
                "□□▷",
                "■>"
            };//배열문자로 그리기 

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어x 플레이어y
                Console.SetCursorPosition(playerX, playerY + i);

                ///문자열배열 출력
                Console.WriteLine(player[i]);
            }


        }

        //충돌 처리

        public void ClashEnemyAndBullet(Enemy enemy)
        {

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1) && playerBullet[i].x <= (enemy.enemyX + 1)) //충돌검사 
                        {

                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false; //미사일도 준비상태

                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1) && playerBullet2[i].x <= (enemy.enemyX + 1)) //충돌검사 
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; //미사일도 준비상태

                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1) && playerBullet3[i].x <= (enemy.enemyX + 1)) //충돌검사 
                        {
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; //미사일도 준비상태

                            Score += 100;
                        }
                    }
                }
            }
        }
        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 2);
            Console.Write("Item : " + itemCount);
            Console.SetCursorPosition(63, 3);
            Console.Write("┗━━━━━━━━━━━━━━┛");

        }

        //아이템 충돌이 일어나면 양쪽 미사일 발사
        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX - 2)
                {
                    item.ItemLife = false;
                    if (itemCount < 3)
                    {
                        itemCount++;
                    }
                    for (int i = 0; i < 20; i++) //총알초기화 
                    {
                        playerBullet[i] = new BULLTE();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLTE();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new BULLTE();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }

    }

    public class Enemy //적 클래스
    {
        public int enemyX; //x좌표
        public int enemyY; // y좌표

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw() // 적그리기 
        {
            string enemy = "<<=0<";
            Console.SetCursorPosition(enemyX, enemyY); // enemy 좌표
            Console.Write(enemy); // 출력
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--;

            if (enemyX < 1) //화면 왼쪽넘어가면 새로 좌표설정 
            {
                enemyX = 77; //좌표77
                enemyY = rand.Next(2, 22); //2~21
            }
        }
    }

    //아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "☆Item★";
            Console.Write(ItemSprite);

        }

        public void ItemMove()
        {
            if (itemX <= 1 || itemY < 1)
            {
                ItemLife = false;
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

            Player player = new Player(); //플레이어 생성
            Enemy enemy = new Enemy(); //적생성 

            //유니티처럼 속도 프레임속도
            int dwTime = Environment.TickCount; // 1 : 1000 초가 흐른다

            while (true)// 무한반복
            {
                // 0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    //총알
                    player.BulletDraw();


                    enemy.EnemyMove(); //적 이동
                    enemy.EnemyDraw(); //적그리기

                    //충돌처리

                    player.ClashEnemyAndBullet(enemy);


                    //총알 
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                }
            }
        }
    }
}
