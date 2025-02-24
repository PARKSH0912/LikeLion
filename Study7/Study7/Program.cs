using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Study7
{
    class Program
    {
        static void Main(string[] args)
        {

            ////단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //Console.WriteLine(!flag); //논리 부정 : False

            //~ 비트 반전
            // 10   1010
            //      0101    4바이트    0000 0000 0000 0000 0000 0000 0000 1010

            //int num = 10;
            //int result = ~num; // 모든 비트 반전 : 1111 0101 결과 -11

            //Console.WriteLine("원래 값 : " + num);
            //Console.WriteLine("~연산자 적용 후: " + result);


            //캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi; //실수형 -> 정수형로 변환

            //Console.WriteLine(integerPi); //3

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;


            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;
            //average = (float)sum / 3; //평균

            //Console.WriteLine("총점 :" + sum);
            //Console.WriteLine("평균 :" + average);


            //int a = 10,b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);


            //문자열 연결 연산자

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName); // 출력

            //int a = 10;
            //a += 5; // a= a+5;
            //Console.WriteLine(a);

            //Console.WriteLine("문제 1");

            //int iKor = 0;
            //int iEng = 0;
            //int iMath = 0;
            //int sum = 0;
            //float averange = 0.0f;

            //Console.WriteLine("국어점수 :");
            //iKor = int.Parse(Console.ReadLine());
            //Console.WriteLine("영어점수 :");
            //iEng = int.Parse(Console.ReadLine());
            //Console.WriteLine("수학점수 :");
            //iMath = int.Parse(Console.ReadLine());

            //sum = iKor + iEng + iMath; // 총점
            //averange = (float)sum / 3; // 평균 

            //Console.WriteLine("총점 :" + sum);
            //Console.WriteLine("평균 :" + averange.ToString("F2"));


            //Console.WriteLine("문제 2");

            //int integer = 0;

            //Console.WriteLine("정수를 입력하시오 :");
            //integer = int.Parse(Console.ReadLine());


            //Console.WriteLine("원래의 값 :" + integer);
            //Console.WriteLine("비트값 :" + ~integer);

            //증감 연산자   

            //int b = 3;

            ////전위 ++b. 후위 b++ 
            ////전위는 라인에서 더해진다 
            //++b;
            //Console.WriteLine("B의 값은 : " + b);
            //++b;
            //Console.WriteLine("B의 값은 : " + b);

            ////후위는 라인에서 안 더해지고 다음 라인에서는 더해진다
            //int c = 3;
            //Console.WriteLine("c의 값은 : "+(c++)); // c=3





        }
    }
}
