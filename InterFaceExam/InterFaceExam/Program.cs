﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExam
{
    //인터페이스를 활용하면 객체가 어떤 특정한 동작을 보장하면서도 다양한 형태로 사용
    //여러 동물을 공통된 방식으로 다룰수있다

    //인터페이스 정의
    interface IAnimal
    {
        void speak();
    }

    class Dog : IAnimal
    {
        public void speak()
        {
            Console.WriteLine("멍멍");
        }


    }
    class Cat : IAnimal
    {
        public void speak()
        {
            Console.WriteLine("야옹~");
        }


    }

    //인터페이스를 활용한 공통메서드 

    class AnimalTrainer
    {
        public void Train(IAnimal animal)
        {
            Console.WriteLine("동물이 소리를 냅니다");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            AnimalTrainer trainer = new AnimalTrainer();

            IAnimal mydog = new Dog();
            IAnimal mycat = new Cat();

            trainer.Train(mycat);
            trainer.Train(mydog);


        }
    }
}
