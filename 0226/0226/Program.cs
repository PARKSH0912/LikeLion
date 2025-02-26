using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _0226
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Q1. 배열 요소 출력");
            //int[] size = new int[5] { 10, 20, 30, 40, 50 }; ;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(size[i]+" ");
            //}


            //Console.WriteLine("Q2. 배열 요소 합 구하기");

            //int[] size_2 = new int[5];
            //int sum=0;

            //for(int i = 0; i<5; i++)
            //{
            //    Console.WriteLine("정수를 입력하세요");
            //    int input = int.Parse(Console.ReadLine());
            //    size_2[i] = input;
            //    Console.WriteLine($"정수 {size_2[i]}가 입력되었습니다");
            //    sum += size_2[i];
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"모든 수의 합 : {sum}");



            //Console.WriteLine("3.최대값 찾기");
            //int[] size = new int[5] { 3, 8, 15, 6, 2 };
            //int max = 0;

            //for (int i = 0; i<5; i++)
            //{
            //    if (max > size[i]) max = max;
            //    else max = size[i];
            //}
            //Console.WriteLine($"가장 큰 값은 : {max}이다");



            //Console.WriteLine("4. 1부터 10까지 출력");

            //for(int i = 0; i<10; i++)
            //{
            //    Console.WriteLine(i+1);
            //}



            //Console.WriteLine("5. 짝수만 출력 (while문)");

            //while(true)
            //{

            //    for (int i = 1; i < 11; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    break;
            //}

            //Console.WriteLine("6. 배열 요소 출력 (foreach문)");

            //int[] size = new int[5] { 1, 2, 3, 4, 5 };

            //foreach(int sizes in size)
            //{
            //    Console.Write(sizes+" ");
            //}


            //Console.WriteLine("7. 두 수의 합을 구하는 함수");
            //Console.WriteLine("첫번째 숫자를 입력하시오");
            //int input1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("두번째 숫자를 입력하시오");
            //int input2 = int.Parse(Console.ReadLine());
            //int sum = input1 + input2;
            //Console.WriteLine("두 숫자의 합은 : " + sum);




            //Console.WriteLine("8. 문자열 길이 반환 함수");

            //Console.WriteLine("문자를 입력하세요");
            //string input = Console.ReadLine();
            //Console.WriteLine("문자열의 길이 : " + input.Length);



            Console.WriteLine("9. 가장 큰 수 반환 함수");

            int[] input = new int[3];

            Console.WriteLine("첫번째 숫자를 입력하시오");
            input[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 입력하시오");
            input[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("세번째 숫자를 입력하시오");
            input[2] = int.Parse(Console.ReadLine());

            int max = 0;

            for(int i =0; i<3; i++)
            {
                if (max > input[i]) max = max;
                else max = input[i];
            }
            Console.WriteLine("가장 큰 값은 : "+max);
        }
    }
}
