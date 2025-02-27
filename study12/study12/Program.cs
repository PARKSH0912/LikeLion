using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study12
{
    class Program
    {

        //1. 매개 변수도 반환값도 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }

        //2. 매개변수만 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //3,반환값만 있는경우
        static int Getnumber()
        {
            return 42;
        }


        //4. 매개변수와 상관없이 있는 변수
        static int Add(int a, int b)
        {
            return a + b;
        }

        //5. 기본값을 가진 매개변수 
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        //6. 함수 오버로딩(Overloading)
        
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }


        // out 키워드 (여러 값을 변환할때)
        static void Divide(int a ,int b , out int quotient, out int remainer)
        {
            quotient = a / b;
            remainer = a % b;
        }


        //8.ref 키워드 (값을 참조하여 수정
        static void Increase(ref int num)
        {
            num += 10;
        }

        static void Main(string[] args)
        {
            //PrintHello();

            //PrintMessage("반갑습니다");

            //int num = Getnumber();
            //Console.WriteLine(num);

            //int result = Add(3, 5);
            //Console.WriteLine(result);

            //Greet();
            //Greet("철수");

            //Console.WriteLine(Multiply(3, 4));
            //Console.WriteLine(Multiply(2.5, 3.5));

            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"몫: {q}, 나머지 {r}"); //출력 3 , 나머지 1

            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);

        }
    }
}
