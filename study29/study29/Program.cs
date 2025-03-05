using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study29
{
    //메서드 오버라이딩(overRiding)
    //부모 클래스의 메서드를 자식 클래스에서 재정의(overriding)하여 다른 동작을 수행할수있습니다.

    class Animal
    {
        public string name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        //부모 클래스의 메서드를 오버라이딩(재정의)
        public override void Speak()
        {
            Console.WriteLine($"{name}이 멍멍 짖습니다.");
        }
    
    
    }




    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();

            animal.name = "일반동물";
            animal.Speak();     //부모클래스의 기본메서드 실행

            Dog dog = new Dog();

            dog.name = "바둑이";
            dog.Speak();        // 오버라이딩된 메서드 실행
        }
    }
}
