using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study38
{
    class MyResuorce
    {

        ~MyResuorce()
        {
            Console.WriteLine("삭제될때 호출");
        }
    }
    

    class Program
    {        
        //ref 포인터 개념참조
        //메서드 ref,out
        static void Increase(ref int x)
        {
            x++;
        }


        //Out은 반환이 여러개일때 유용하다.
        static void OutFunc(int a,int b, out int x, out int y)
        {
            x = a;
            y = b;
        }
        static void Main(string[] args)
        {
            //MyResuorce r = new MyResuorce();
            ////GC에 의해 나중에 소멸자 호출

            ////가비지 컬렉션은 더이상 참조되지 않는 객체를 정리합니다

            //int a = 10;
            //Increase(ref a);
            //Console.WriteLine("A의 값:" + a);


            int a = 10;
            int b = 20;
            int x, y;
            OutFunc(a, b, out x, out y);
            Console.WriteLine("X :" + x + " Y : " + y);




        }
    }
}
