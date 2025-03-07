using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0307_Test
{
    public class Player
    {
        public int health;
        public string name;
        public int attack;

        public void Job_Select()
        {



            Console.WriteLine("직업을 선택하세요 : ");

            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 도적");
            int iInput = int.Parse(Console.ReadLine()); 

            if (iInput == 1)
            {
                string name = "전사";
                int attack = 10;
                int health = 100;

            }
            else if (iInput == 2)
            {
                string name = "마법사";
                int attack = 20;
                int health = 70;
            }
            else if (iInput == 3)
            {
                string name = "도적";
                int attack = 15;
                int health = 85;
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }


    }
}
