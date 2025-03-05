using study27;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study27
{
    //부모 클래스
    class Animal
    {
        public string Name { get; set; }

    public void Eat()
        {
            Console.WriteLine($"{Name}이 음식을 먹고았습나다");
        }
    }

    // 자식클래스 (파생클래스) 

    class Dog : Animal
    {   
        public void Bark()
        {
            Console.WriteLine($"{Name}이 멍멍 짖습니다.");
        }

    }   


class Program
    {
        static void Main(string[] args)
        {
            Dog mydog = new Dog();

            mydog.Name = "바둑이"; //부모 클래스의 속성사용
            mydog.Eat(); //부모 클래스의 메서드 호출
            mydog.Bark(); //자기 메서드 호출 가능





        }
    }
}
