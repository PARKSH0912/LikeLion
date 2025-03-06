using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRpg;

namespace TextRpg
{
    class MainGame
    {

        public Player m_pPlayer = null;
        //필드객체
        public Field m_pField = null;

        //초기화해주는 함수
        public void Initialize()
        {
            //플레이어 생성 및 직업선택
            m_pPlayer = new Player();
            m_pPlayer.SelectJob();
        }


        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render(); //플레이어 출력
                Console.WriteLine("1.사냥터 2.종료 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2) break;
                if (iInput == 1)
                {
                    //사냥터 구현
                    if (m_pField == null)
                    {
                        m_pField = new Field();
                        //필드로 갈때 플레이어 넣어주기
                        m_pField.setPlayer(ref m_pPlayer);
                    }
                    m_pField.Progress();

                }

            }

        }
        public MainGame() { }

        ~MainGame() {  }
    }
}
