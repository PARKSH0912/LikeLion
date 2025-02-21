using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //////사용자 입력을 문자열 받기 
            ////Console.WriteLine("이름을 입력하세요");
            ////string userName = Console.ReadLine(); // 사용자로 부터 입력 받기

            ////Console.WriteLine($"안녕하세요, {userName}님!");

            ////문자열을 정수로 변환
            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine(); //사용자로부터 입력받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!"); //변환된값 사용
            //Console.WriteLine("내년에는" + age + "살이 되겠군요!"); //문자열 + 정수
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age); // 초기버전 

            float Ruin = 0.0f;
            float Card_Gauge = 0.0f;
            float Awakening = 0.0f;
            int MaxMana = 0;
            int BattleMana = 0;
            int NonBattleMana = 0;
            float PlayerSpeed = 0.0f;
            float MobSpeed = 0.0f;
            float CarryingSpeed = 0.0f;
            float SkillRecycle = 0.0f;

            Console.Write("루인 스킬 피해를 입력하세요 : ");
            Ruin = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량을 입력하세요 : ");
            Card_Gauge = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해를 입력하세요 : ");
            Awakening = float.Parse(Console.ReadLine());

            Console.Write("최대 마나를 입력하세요 : ");
            MaxMana = int.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            BattleMana = int.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량을 입력하세요 : ");
            NonBattleMana = int.Parse(Console.ReadLine());

            Console.Write("이동속도를 입력하세요 : ");
            PlayerSpeed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도를 입력하세요 : ");
            MobSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도를 입력하세요 : ");
            CarryingSpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소를 입력하세요 : ");
            SkillRecycle = float.Parse(Console.ReadLine());


            Console.WriteLine($"루인 스킬 피해: {Ruin}%"); 
            Console.WriteLine($"카드 게이지 획득량: {Card_Gauge}%"); 
            Console.WriteLine($"각성기 피해: {Awakening}%"); 
            Console.WriteLine($"최대 마나: {MaxMana}"); 
            Console.WriteLine($"전투 중 마나 회복량: {BattleMana}"); 
            Console.WriteLine($"비 전투 중 마나 회복량: {NonBattleMana}"); 
            Console.WriteLine($"이동속도 : {PlayerSpeed}%"); 
            Console.WriteLine($"탈 것 속도: {MobSpeed}%"); 
            Console.WriteLine($"운반 속도: {CarryingSpeed}%"); 
            Console.WriteLine($"스킬 재사용 대기시간 감소: {SkillRecycle}%"); 



        }
    }
}
