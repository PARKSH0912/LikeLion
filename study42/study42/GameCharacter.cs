using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study42
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }

        protected GameCharacter(string name, int health, int attack, int defence)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defence = defence;
        }

        //추상 메서드 : 모든 캐릭터가 구현해야 하는 기본 공격

        public abstract void BasicAttack(GameCharacter Target);

        //추상메서드 : 모든 캐릭터가 구현해야하는 특수공격

        public abstract void SpecialAttack(GameCharacter Target);



        //일반메서드 : 모든캐릭터가 공유하는 기능

        public void TakeDamage(int damage)
        {
            int actualDamae = Math.Max(1, damage - Defence);

            Health = Math.Max(0, Health - actualDamae);

            Console.WriteLine($"{Name}이 {actualDamae}의 피해를 받았습니다. 남은체력 : {Health}");

        }


    }
}
