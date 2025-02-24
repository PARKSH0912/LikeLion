using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study6
{
    class Program
    {
        static void Main(string[] args)
        {

            ////이진수를 정수로 변환
            //Console.WriteLine("2진수를 입력하세요");
            //string binaryInput = Console.ReadLine(); //입력받는다 문자열
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수->  10진수

            ////정수를 2진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 -> 2진수

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            //var를 사용하여 변수선언 
            //var name = "Alice"; // 문자열로 추론
            //var age = 25; // 정수로 추론 
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이 {age}, 학생 여부 : {isStudent}");

            //default 키워드 사용한 기본값 설정
            //int defaultInt = default; //기본값 : 0
            //string defaultString = default; //기본값 : null
            //bool defaultBool = default; //기본값 : false

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");

            //int a = 5, b = 3;
            //int sum = 0;

            //sum = a + b; // 산술 연살자 사용 
            //Console.WriteLine($"합 : {sum}"); 
            //sum = a - b; // 산술 연살자 사용 
            //Console.WriteLine($"빼기 : {sum}"); 
            //sum = a * b; // 산술 연살자 사용 
            //Console.WriteLine($"곱하기 : {sum}"); 
            //sum = a / b; // 산술 연살자 사용 
            //Console.WriteLine($"나누기 : {sum}"); 

            //int c = 0 , d = 0;

            //c = 5;
            //d = 2;

            //sum = c % d; // 나머지 구하는 연산자
            //Console.WriteLine($"나머지 : {sum}"); //출력 : 1

            //int number = 7;

            //int sum = 0;

            //sum = number % 2; //0 나오면 짝수 1홀수

            //Console.WriteLine("짝수 홀수 판별 : " + sum);

            bool isEqual = false; // 거짓 0
            int a = 5;
            int b = 5;

            // 관계형 연산자
            isEqual = (a == b); // a랑 b랑 같은가?

            Console.WriteLine("같은가? " + isEqual);





        }
    }
}
