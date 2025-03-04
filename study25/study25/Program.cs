using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace study25
{
    class Program
    {
        //class Cup<T>
        //{
        //    public T Content { get; set; }
        //}


        class SimpleColletion : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach(var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }



        static void Main(string[] args)
        {

            //var colletion = new SimpleColletion();
            //foreach(var i in colletion)
            //{
            //    Console.WriteLine(i);
            //}


            //제네릭 사용하기(Genenrics)
            //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용클래스를 만들수있습니다


            //Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupOfString : {cupOfString.Content}");
            //Console.WriteLine($"CupOfInt : {cupOfInt.Content}");


            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while(stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}


            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //     public interface IEnumerator
            //{
            //    bool MoveNext(); // 다음 요소로 이동 (이동할 요소가 있으면 true 반환)
            //    object Current { get; } // 현재 요소 반환
            //    void Reset(); // 처음 위치로 리셋
            //}
            //C#컬렉션 순회 반복할수있는 인터페이스




            // ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            //IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기


            //while (enumerator.MoveNext()) //다음 요소가 있는지 확인
            //{
            //    Console.WriteLine(enumerator.Current);//현재 요소 출력
            //}


            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach(var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}


            //string str = null;

            //if(str == null)
            //{
            //    Console.WriteLine("str is null");
            //}

            //int? nullableInt = null;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");


            //nullableInt = 10;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");


            //null값을 다루는 연산자 소개하기 ??, ?. 연산자
            //??연산자를 사용해 nulll인 경우 대체값을 제공하고, ?.은 null안전 접근을 합니다

            //string str = null;

            //Console.WriteLine(str ?? "DefaultValue"); //str이 null이면 "Default Value"

            //str = "Hello";

            //Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력

            //if (str != null)
            //{
            //    Console.WriteLine(str.Length);
            //}

            //LINQ는 확장메서드 형태로제공
            //LINQ(Language integrated Query)를 사용해 컬렉션을 쿼리할수있습니다.

            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
