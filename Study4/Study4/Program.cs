using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Study4
{
    class Program
    {
        static void Main(string[] args)
        {

            ////문자열
            //string greeting; //문자열 변수를 선언
            //greeting = "Hello World"; // 변수에 값을 저장

            ////변수의 값을 사용
            //Console.WriteLine(greeting); //출력 : Hello.World;

            //변수 선언과 초기화를 한번에 수행 Ctrl /

            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; //실수형 변수 선언과 초기화
            //string city = "Seoul'"; //문자열 변수 선언과 초기화 


            ////변수 출력
            //Console.WriteLine(score); //출력 100
            //Console.WriteLine(temperature); //출력 36.5
            //Console.WriteLine(city); //출력 : Seoul


            //int x = 10, y = 20, z = 30; // 정수형 변수 x,y,z 를 선언하고 초기화 
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double Pi = 3.14159; //상수 pi선언 및 초기화
            //const int MaxScore = 100; //정수형 상수 선언 

            ////출력

            //Console.WriteLine("Pi : " + Pi); //출력 : Pi : 3.14159
            //Console.WriteLine("Max Score: " + MaxScore); // 출력 : MaxScore : 100

            string att_name = "공격력";
            int att = 16755;
            string Maxhp_name = "최대 생명력";
            int hp = 78103;

            string Stats_name1 = "치명";
            int Crit = 36;
            string Stats_name2 = "특화";
            int Specialization = 1017;
            string Stats_name3 = "제압";
            int Domination = 41;
            string Stats_name4 = "신속";
            int Swiftness = 611;
            string Stats_name5 = "인내";
            int Endurance = 22;
            string Stats_name6 = "숙련";
            int Expertise = 39;


            Console.WriteLine(att_name + (" ") + att);
            Console.WriteLine(Maxhp_name + (" ") + hp);
            Console.WriteLine(Stats_name1 + (" ") + Crit);
            Console.WriteLine(Stats_name2 + (" ") + Specialization);
            Console.WriteLine(Stats_name3 + (" ") + Domination);
            Console.WriteLine(Stats_name4 + (" ") + Swiftness);
            Console.WriteLine(Stats_name5 + (" ") + Endurance);
            Console.WriteLine(Stats_name6 + (" ") + Expertise);




        }
    }
}
