using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study30
{

    //업캐스팅(Upcasting)
    //자식 클래스->부모클래스로 변환하는것
    //암시적 변환이 가능(컴파일러가 자동변환)
    //안전: 데이터 손실 없이 변환가능

    //다운캐스팅
    //명시적변환이 필요(타입)
    //불완전함 -> 실행중 InvaildCastException발생가능
    //as is키워드로 안전하게 변환가능


    class Animal // 부모클래스
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다");
        }


    }


    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    
    
    }



    class Program
    {
        static void Main(string[] args)
        {

            Dog mydog = new Dog();      //자식클래스 객체 생성
            Animal animal = mydog;      //업캐스팅(Dog->animal)

            animal.Speak();             //사용가능
            // animal.Bark();           //오류 업캐스팅후 자식클래스의 메서드는 접근불가 
            mydog.Bark();

            Animal animals = new Animal();   //업캐스팅
            // Dog mydog = (Dog)animal   //다운캐스팅(명시적변환)




            if (mydog != null)
            {
                mydog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }


            if (animal is Dog mydog1)
            {
                mydog1.Bark();
            }
            else
            {
                Console.WriteLine("변환할수 없습니다");
            }

        }
    }
}
