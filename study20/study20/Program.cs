using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace study20
{
    class Person
    {
        //    public string Name = "홍길동";
        //    public int Age;
        //    //기본생성자
        //    //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //    //클래스와 같은이름가지며, 반환형이 없다(void도 사용하지않음)
        //    //객체를 만들때 필요한 초기값을 설정할때 사용많이한다.)





        //    public Person(string name, int age)

        //    {
        //        Name = name;
        //        Age = age;
        //        Console.WriteLine("기본 생성자가 실행됨");
        //    }


        //    public void ShowInfo()
        //    {
        //        Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        //    }

        //}



        //마린 클래스를 만드세요.
        //이름, 미네랄
        //기본 생성자 , 인자있는 생성자 

        class Marin
        {
            public string Name;
            public int Mineral;

            public Marin()
            {
                Name = "Marin";
                Mineral = 50;
            }

            public Marin(string name, int mineral)
            {
                Name = name;
                Mineral = mineral;
                Console.WriteLine("기본 생성자가 실행됨");
            }

            public void ShowInfo()
            {
                Console.WriteLine($"이름 :{Name}, 미네랄 {Mineral}");
            }

        }

        class SCV
        {
            public string Name;
            public int Mineral;
            public SCV()
            {
                Name = "SCV";
                Mineral = 50;
            }
            public SCV(string name, int mineral)
            {
                Name = name;
                Mineral = mineral;
            }


            public void ShowInfo()
            {
                Console.WriteLine($"이름 :{Name}, 미네랄 : {Mineral}");
            }
        }

        //배럭클래스를만드세요
        //Barracks 150
        //this 키워드를 이용해보자
        //this 자기자신을 가르킨다.


        class Barracks
        {
            public string Name;
            public int Mineral;
            public Barracks()
            {
                Name = "Barracks";
                Mineral = 150;
            }
            public Barracks(string name, int mineral)
            {
                this.Name = name;
                this.Mineral = mineral;
            }


            public void ShowInfo()
            {
                Console.WriteLine($"이름 :{Name}, 미네랄 : {Mineral}");
            }
        }

        //미네랄 클래스를 만드시오
        //Mineral 1500 기본


        class Mineral
        {
            public int MineralCount;

            public Mineral()
            {
                MineralCount = 1500;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
            }

        }

        class Game
        {
            public static int mineral;
            public static int gas;
            public static int charCount;

            public static void ShowInfo()
            {
                Console.WriteLine($"미네랄 : {mineral} 가스 : {gas} 인구수 : {charCount}");
            }

        }



        class Program
        {
            static void Main(string[] args)
            {

                Game.mineral = 50;
                Game.gas = 0;
                Game.charCount = 4;
                Game.ShowInfo();






                //클래스
                //
                //Person p1 = new Person("철수",25); //객체 생성 instance
                //p1.ShowInfo();

                //Person p2 = new Person("영희", 25); //객체 생성 instance
                //p2.ShowInfo();

                Marin marin = new Marin();
                marin.ShowInfo();

                SCV scv = new SCV();
                scv.ShowInfo();

                Barracks barracks = new Barracks();
                barracks.ShowInfo();

                Mineral[] mineral = new Mineral[7];
                {
                    for (int i =0; i<mineral.Length; i++)
                    {
                        mineral[i] = new Mineral();
                        mineral[i].ShowInfo();
                    }


                }


            }
        }
    }
}

