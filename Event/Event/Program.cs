using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    //게임 캐릭터 클래스

    class Character
    {
    
        public string Name { get; private set; } //캐릭터 이름
        public int Health { get; private set; } //캐릭터 체력

        //이벤트 정의 - 캐릭터가 데미지를 입었을때 발생
        //EventHandler C#에서 제공하는 기본 델리게이트타입
        //이벤트는 외부에서 직접 호출할수 없고 , +=와 -=연산자로만 접근가능

        public event EventHandler OnDamaged;


        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;

            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은체력 : {Health}");


            //이벤트 발생 (구독자가 있는 경우에만
            //?. 연산자는 OnDamaged가 NULL이 아닐떄만 Invoke 메서드 호출
            //EventArgs.Empty는 추가 데이터가 없을때 사용하는 빈 이벤트 인자

            OnDamaged?.Invoke(this, EventArgs.Empty);
        }





    }




    class Program
    {


        //이벤트 핸들러 메서드
        //EventHandler 델리게이트와 일치하는 시그니처를 가져와야함
        //sender : 이벤트를 발생시킨 객체(여기서는 Character객체)
        //e: 이벤트와 관련된 추가 데이터 (여기서는 사용하지않음)

        static void Hero_OnDamaged(Object sender , EventArgs e)
        {
            //sender를 Character 타입으로 형변환
            Character character = (Character)sender;

            Console.WriteLine($"이벤트알림 : {character.Name}이 데미지를 입었습니다.!" + $"현재 체력 : {character.Health}");

        }



        static void Main(string[] args)
        {


            Character Hero = new Character("용사", 100);

            //이벤트 구독++
            //이벤트가 발생했을때 실행될 메서드 등록
            Hero.OnDamaged += Hero_OnDamaged;

            //데미지 입히기
            //TakeDamage 메서드 내에서 Ondamgage이벤트가 발생함
            Hero.TakeDamage(30);


            //이벤트 구독취소 -=
            //더이상 이벤트 발생시 메서드가 호출되지않음
            Hero.OnDamaged -= Hero_OnDamaged;
            Console.WriteLine("이벤트 구독취소");
            Hero.TakeDamage(20); //이벤트 발생함수는 샐행하지만 내용은 실행안함


        }
    }
}
