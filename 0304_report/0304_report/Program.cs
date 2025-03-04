using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0304_report
{
    class Program
    {
        class Warrior 
        { 
            public string name { get; set; }
        
            public int score { get; set; }

            public int strength { get; set; }
        }



        static void Main(string[] args)
        {

            //1.

            //Warrior warrior = new Warrior();

            //warrior.name = "Warrior";
            //warrior.score = 105;
            //warrior.strength = 6;

            //Console.WriteLine($"이름 : {warrior.name} | 점수 : {warrior.score} | 힘 : {warrior.strength}");


            //2.
            //try
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    Console.WriteLine(number);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"올바른 숫자를 입력하세요!");
            //}


            //3.

            //List<string> list = new List<string>();

            //list.Add("사과");
            //list.Add("바나나");
            //list.Add("포도");


            //foreach (string i in list)
            //{
            //    Console.WriteLine($"List : {i}");
            //}

            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("첫번째 작업");
            //queue.Enqueue("두번째 작업");
            //queue.Enqueue("세번째 작업");


            //while (queue.Count > 0)
            //{
            //    Console.WriteLine( $"Queue : { queue.Dequeue()}");
            //}

            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine($"Stack : {stack.Pop()}");
            //}



            ////4.
            //string str = Console.ReadLine();

            //Console.WriteLine($"대문자 변환: {str.ToUpper()}");       //대문자 변환
            //Console.WriteLine($"문자 변경: {str.Replace("C#", "Csharp")}");       // C#을 CSharp로 변경
            //Console.WriteLine($"문자열 길이 출력: {str.Length}");       // 문자열길이



            //5.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = 0;
            var evennumber = numbers.Where(n => n % 2 == 0);

            foreach(var num in evennumber)
            {
                Console.WriteLine($"짝수 : {num}");
            }

            foreach(var num in numbers)
            {
                result += num;
            }

            Console.WriteLine($"모든 숫자의 합 {result}");


        }
    }
}
