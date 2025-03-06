using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study40
{
    //부모클래스의 생성자 호출

    class Parent
    {   
        
        public Parent(string message)
        {
            Console.WriteLine("부모생성자 " + message); //2실행 
        }

    }

    class Child : Parent
    {

        public Child() : base("하하하성공") //부모 생성자호출 , 1실행
        {
            Console.WriteLine("자식 생성자 호출"); // 3실행
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Child child = new Child();

        }
    }
}
