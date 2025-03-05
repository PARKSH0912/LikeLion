using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study34
{

    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "UnKnown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}이 치료할 수 없습니다");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동 합니다");
        }
    }

    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다.! (공격력이 약함)");
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다. (기계유닛만 가능)");
        }
    }

    //Marin 유닛 (총기 공격)

    class Marin : Unit
    {
        public Marin()
        {
            Name = "Marin";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("Marine이 소총으로 공격합니다");
        }

    }

    //Medic 유닛 (회복)
    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다.");
        }

    }

    //Tank 유닛 (강력한 공격)
    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine("Tank가 시즈모드로 강력한 포격!");
        }

        public override void Move()
        {
            Console.WriteLine("탱크가 천천히 움직입니다");
        }

    }






    class Program
    {
        static void Main(string[] args)
        {

            List<Unit> units = new List<Unit>();

            units.Add(new SCV());
            units.Add(new Marin());
            units.Add(new Medic());
            units.Add(new Tank());

            
            //모든 유닛을 순회하며 다형성 적용

            foreach (var unit in units)
            {
                unit.Move();        //이동
                unit.Attack();      //공격
                Console.WriteLine();
            }

            SCV scv = new SCV();
            scv.Heal(units[3]);

            //Medic이 Marin 치료시도
            Medic medic = new Medic();
            medic.Heal(units[1]);



        }
    }
}
