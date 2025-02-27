using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study13
{
    class Program
    {
        //params 키워드 (가변 매개변수)

        static int sum(params int[] numbers)
        {
            int total = 0;
            foreach(int num in numbers)
            {
                total += num;
            }
            return total;
        }

        //재귀 함수 (자기 자신을 호출)

        static int Factiorial(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("*" + n);
                return 1;
            }
            Console.WriteLine("*" + n);
            return n * Factiorial(n - 1);
        }

        static void Print()
        {
            Console.WriteLine("나는 재귀 함수이다");
            Print();
        }
        
        static void Main(string[] args)
        {


            //Console.WriteLine(sum(1, 2, 3)); //출력 6
            //Console.WriteLine(sum(1, 2, 3,4,5,6,7,8,9)); //출력 45

            //Print();

            Console.WriteLine(Factiorial(5));
            

        }
    }
}
