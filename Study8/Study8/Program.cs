using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Study8
{
    class Program
    {
        static void Main(string[] args)
        {

            //// 두 값을 비교하여 관계를 평가한다.
            //// == 같다 != 같지않다  <  //  > 

            //int x = 5, y = 10;

            //Console.WriteLine(x < y); // true
            //Console.WriteLine(x == y); // false
            //Console.WriteLine(x != y); // true
            //Console.WriteLine(x > y); // false
            //Console.WriteLine(x >= y); // false
            //Console.WriteLine(x <= y); // true

            //논리 연산자 

            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);
            //// AND : a랑 b가 같아야 함
            //// 1 : 1 true
            //// 1 : 0 false
            //// 0 : 1 false
            //// 0 : 0 false

            //Console.WriteLine(a||b);
            //// OR
            //// 1 : 1 Ture
            //// 1 : 0 Ture
            //// 0 : 1 Ture
            //// 0 : 0 False

            //Console.WriteLine(!a);
            //// Not
            //// True -> False , False -> True

            //비트연산자
            //int x = 5; // 0101
            //int y = 3; // 0011

            //Console.WriteLine(x & y); // AND : 1 (0001)
            //Console.WriteLine(x | y); // or : 7 (0111)
            //Console.WriteLine(x ^ y); // xor : 6 (0110)
            //Console.WriteLine(~x); // NOT : -6

            //int value = 4; //0100

            //Console.WriteLine(value << 1); //왼쪽 이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //오른쪽 이동 : 2 (0010)


            //int a = 10, b = 20;

            //int max;
            //max = (a < b) ? a : b; // 삼항 연산자

            //// (비교) ? 참 : 거짓 
            //// a=10 .b=20 a < b 보다 크니 참위치에있는 a를 출력 

            //Console.WriteLine(max); 

            ////
            //int key = 1;
            //string str;

            //str = (key == 1) ? "문이열렸습니다" : "문을 못열었습니다";
            //Console.WriteLine(str);
            //str = (key == 2) ? "문이열렸습니다" : "문을 못열었습니다";
            //Console.WriteLine(str);

            //int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선 
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5; // 괄호 우선순위 먼저계산
            //Console.WriteLine(adjustedResult);


            //int score = 95;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else
            //{
            //    Console.WriteLine("B 학점");
            //}

            //if (true)
            //{
            //    Console.WriteLine("트루");
            //}
            //else
            //{
            //    Console.WriteLine("팔스");
            //}


            //string GameID = "멋사검존";

            //if(GameID == "멋사검존")
            //{
            //    Console.WriteLine("일치합니다");
            //}
            //else
            //{
            //    Console.WriteLine("일치하지않습니다");
            //}

            //int score = 75;
            //if (score>= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score>= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}



            // 가지고있는 소지금을 입력하세요 :
            // 0~100 무한의 대검 +1
            // 101~200 카타나 +2
            // 201~300 진은검 +3
            // 301~400 집판검 +4
            // 401~500 엑스칼리버 +5
            // 501~600 유령검 +6

            //2단계
            //캐릭터 이름 
            //공격력 : 100 +1 


            //int gold = 0;
            //string name;

            //Console.WriteLine("가지고있는 소지금을 입력하세요");
            //gold = int.Parse(Console.ReadLine());
            //Console.WriteLine("캐릭터 이름을 입력하세요");
            //name = Console.ReadLine();

            //if (gold >= 600)
            //{
            //    Console.WriteLine("캐릭터 이름 : " +name);
            //    Console.WriteLine("공격력 : 106");
            //    Console.WriteLine("무기 : 유령검");
            //}
            //else if (gold >= 500)
            //{
            //    Console.WriteLine("캐릭터 이름 : " + name);
            //    Console.WriteLine("공격력 : 105");
            //    Console.WriteLine("무기 : 엑스칼리버");
            //}
            //else if (gold >= 400)
            //{
            //    Console.WriteLine("캐릭터 이름 : " + name);
            //    Console.WriteLine("공격력 : 106");
            //    Console.WriteLine("무기 : 집판검");
            //}
            //else if (gold >= 300)
            //{
            //    Console.WriteLine("캐릭터 이름 : " + name);
            //    Console.WriteLine("공격력 : 106");
            //    Console.WriteLine("무기 : 진은검");
            //}
            //else if (gold >= 200)
            //{
            //    Console.WriteLine("캐릭터 이름 : " + name);
            //    Console.WriteLine("공격력 : 106");
            //    Console.WriteLine("무기 : 카타나");
            //}
            //else
            //{
            //    Console.WriteLine("캐릭터 이름 : " + name);
            //    Console.WriteLine("공격력 : 101");
            //    Console.WriteLine("무기 : 무한의 대검");
            //}

            

            Console.WriteLine("문제1. 세 정수의 최대값 구하기");

            int func1 = 0;
            int func2 = 0;
            int func3 = 0;

            Console.WriteLine("첫번째 정수의 값을 입력하시오");
            func1 = int.Parse(Console.ReadLine());

            Console.WriteLine("두번째 정수의 값을 입력하시오");
            func2 = int.Parse(Console.ReadLine());

            Console.WriteLine("세번째 정수의 값을 입력하시오");
            func3 = int.Parse(Console.ReadLine());

            if (func1 > func2)
            {
                if (func1 > func3)
                {
                    Console.WriteLine("최대값 : " + func1);
                }
                else
                {
                    Console.WriteLine("최대값 : " + func3);
                }
            }
            else
            {
                if (func2 > func3)
                {
                    Console.WriteLine("최대값 : " + func2);
                }
                else
                {
                    Console.WriteLine("최대값 : " + func3);
                }

            }


            Console.WriteLine("문제2. 점수에 따른 학점 평가");
            int score = 0;
            score = int.Parse(Console.ReadLine());

            if(score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            Console.WriteLine("문제2. 간단한 사칙연산 계산기");
            int num1 = 0; 
            int num2 = 0;
            string symbol;

            Console.WriteLine("사용할 첫번째 숫자를 입력하시오");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("사용할 두번째 숫자를 입력하시오 ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("사용할 연산자 기호를 입력하시오");
            symbol = Console.ReadLine();

            if(symbol == "*" )
            {
                Console.WriteLine("결과 : " + (num1 * num2));
            }
            else if (symbol == "/")
            {
                Console.WriteLine("결과 : " + (num1 / num2));
            }
            else if (symbol == "+")
            {
                Console.WriteLine("결과 : " + (num1 + num2));
            }
            else if (symbol == "-")
            {
                Console.WriteLine("결과 : " + (num1 - num2));
            }
            else
            {
                Console.WriteLine("잘못된 연산자");
            }
        }
    }
}
