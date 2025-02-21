using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10; // 정수형 리터럴 
            double pi = 3.14; // 실수형 리터럴 
            char letter = 'A'; // 문자 리터럴 
            string name = "Alice"; // 문자열 리터럴

            Console.WriteLine(number); // 출력 : 10
            Console.WriteLine(pi); // 출력 : 3.14
            Console.WriteLine(letter); // 출력 : A
            Console.WriteLine(name); // 출력 : Alice


            // 캐릭터
            // Hp : 100
            // att : 56.7 
            // 캐릭터 이름 : ??
            // 등급 :  S

            string name_1 = "카타리나"; // 캐릭터 이름 
            double hp = 100; // Hp
            double att = 56.7; // Att
            char rank = 'S'; // 등급 
            string charter = "캐릭터";

            Console.WriteLine(charter);
            Console.WriteLine("체력 :"+ hp);
            Console.WriteLine("공격력 : "+att);
            Console.WriteLine("캐릭터 이름 : "+name_1);
            Console.WriteLine("등급 : "+rank);

        }
    }
}
