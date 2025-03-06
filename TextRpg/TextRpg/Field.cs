using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg
{
    public class Field
    {
        Player m_pPlayer = null;
        //몬스터

        Monster m_pMonster = null;

        //플레이어 maingame에서 생성한거 가지고와야지
        //플레이어가 필드에서 전투를하면 데미지를 입을거고 hp가 깎이겠다

        public void setPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }



        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) break;

                if (iInput <= 3)
                {
                    //몬스터를만들고
                    //1번일때 초보몬스터
                    //2번일때 중급몬스터
                    //3번일대 고급몬스터 
                    CreateMonster(iInput);
                    //싸운다
                    Fight();
                }
                
            }

            void DrawMap()
            {
                Console.WriteLine("1.초보맵");
                Console.WriteLine("2.중수맵");
                Console.WriteLine("3.고수맵");
                Console.WriteLine("4.전단계맵");
                Console.WriteLine("==========");
                Console.WriteLine("맵을 선택하세요 : ");
            }
        }


        public void Create(string _strname, int _iHp , int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster(); //몬스터생성
            INFO tMonster = new INFO();

            tMonster.strName = _strname;         //몬스터 이름
            tMonster.iHp = _iHp;                // 체력
            tMonster.iAttack = _iAttack;        //공격력


            pMonster.SetMonster(tMonster);      //생성된 데이터INFO에 할당

        }


        public void CreateMonster(int input)
        {
            switch (input)
            {

                case 1:
                    //공장처럼 찍어내준다
                    //디자인패턴 팩토리 메서드 패턴
                    Create("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    //공장처럼 찍어내준다
                    //디자인패턴 팩토리 메서드 패턴
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    //공장처럼 찍어내준다
                    //디자인패턴 팩토리 메서드 패턴
                    Create("고수몹", 90, 9, out m_pMonster);
                    break;
            }
        }

        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();     //플레이어 정보출력
                m_pMonster.Render();    //몬스터 정보출력

                Console.WriteLine("1.공격 2.도망 : "); //1,2선택 표쇼ㅣ
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    //플레이어 데미지 주기 몬스터공격력 넣어서 데미지
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    //몬스터 데미지 주기 플레이어 공격력 넣기
                    m_pPlayer.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0) //플레이어 체력이 0이라면 
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }

                }

                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break; //탈출
                }

            }


        }

        public Field() { }
        ~Field() { }

    }

}
