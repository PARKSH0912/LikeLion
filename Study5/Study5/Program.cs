using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식 : 정수와 실수를 다룰 때 사용하는 다양한 타입 
            //int integerNum = 10; //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수
            //double doubleNum = 3.14599; // 배정밀도 실수

            //Console.Write(integerNum); Console.Write(floatNum); Console.Write(doubleNum);

            //정수 데이터형식 : 소수점이 없는 숫자를 표현 
            //int intValue = -100; //4비트 크기의 정수
            //long longValue = 1234567890L; //8바이트 크기의 정수

            //Console.WriteLine(intValue); //출력 -100
            //Console.WriteLine(longValue); //출력 1234567890

            ////부호 있는 정수 : 음수와 양수를 모두 표현 가능 
            //sbyte signedByte = -50; //1바이트 크기
            //short signedShort = -32000; //2바이트 크기 
            //int signedInt = -20000000; //4바이트 크기 

            //Console.WriteLine(signedByte);
            //Console.WriteLine(signedShort);
            //Console.WriteLine(signedInt);

            ////부호없는 정수 데이터 
            //byte unsignedByte = 255; //1바이트크기 
            //ushort unsignedShort = 65000; //2바이트크기
            //uint unsignedInt = 400000000; //4바이트

            //Console.WriteLine(unsignedByte);
            //Console.WriteLine(unsignedShort);
            //Console.WriteLine(unsignedInt);

            //// 실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f; // 단정밀도 실수
            //double doublePrecision = 3.1415926535; //배정밀도 실수(8바이트)
            //decimal highPrecision = 3.14592653545646546545m; //고정밀도 (16비트)

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //int integerValue = 100; // 기본 정수형(int)
            //long longValue = 100L; // 정수형(long)
            //float floatValue = 3.14f; // 실수형(float)
            //double doubleValue = 3.14; // 기본 실수형(double)
            //decimal decimalValue = 3.14m; //고정밀도 실수형(decimal)

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);


            //char형식: 단일 문자를 표현
            //char letter = 'A'; //문자 'A'저장
            //char symbol = '#'; //특수 기호 저장
            //char number = '9'; //숫자 형태 문자 저장 (문자9, 숫자9가 아님)

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);


            ////string 형식 : 여러 문자를 저장
            //string greeting = "Hello World"; // Hello World
            //string name = "Alice"; // Alice

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            ////Hellow World Alice 
            //Console.WriteLine(greeting + " " + name);

            //bool형식 : 참(Ture) =1 , 거짓(False) = 0

            //bool isRunning = true; //프로그램 실행 상태
            //bool isFinished = false; // 프로그램 종료 상태 

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            //// const :변하지 않는 값을 정의
            //const double Pi = 3.14159; //원주율
            //const int MaxScore = 100; //최대 점수

            //Console.WriteLine(Pi); // 출력 3.14159
            //Console.WriteLine(MaxScore); // 출력 100


            //// 닷넷 형식 : 기본 형식의 닷넷표현 
            //System.Int32 number = 123; //int의 닷넷 형식
            //System.String text = "Hello"; //string의 닷넷 형식
            //System.Boolean flag = true; //bool의 닷넷형식

            //Console.WriteLine(number); // 출력 123
            //Console.WriteLine(text);    // 출력 Hello 
            //Console.WriteLine(flag);    // 출력 True


            //int 래퍼 형식의 매서드 활용

            //int number = 123;

            //string numberAsString = number.ToString(); //정수를 문자열로 변환

            ////bool 래퍼형식
            //bool flag = true;

            //string flagAsString = flag.ToString(); //논리값을 문자열로 변환 

            //Console.WriteLine(numberAsString);
            //Console.WriteLine(flagAsString);








        }
    }
}
