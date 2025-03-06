using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study39
{
    //추상 클래스 (Abstract Class)
    //추상클래스는 객체를 생성할수 없는 ㅡㅋㄹ래스로 , 상속을 통해서만 사용할 수있습니다
    // 공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제할때 사용됩니다.
    //abstract 키워드를 사용
    //추상 메서드를 선언만 하고, 구현은 하지않습니다.
    //상속받은 클래스는 반드시 구현해야한다.


    abstract class Animal
    {
        //추상 메서드 (구현 x, 상속받은 클래스가 구현)
        public abstract void MakeSound();


        //일반 메서드
        public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잡니다");
        }

    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("야옹");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Animal myDog = new Dog();

            myDog.MakeSound();
            myDog.Sleep();


            Animal myCat = new Cat();

            myCat.MakeSound();
            myCat.Sleep();




        }
    }
}
