using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace study21
{
    //class Person
    //{
    //    private String name; //내부 변수

    //    //값 설정하기 (Setter)

    //    public void SetName(string newName)
    //    {
    //        name = newName;
    //    }

    //    //값 가져오기
    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}
    //C# 프로퍼티 Property
    //class Person
    //{
    //    private string name; //내부변수

    //    public string Name //프로퍼티
    //    {
    //        get { return name; } // Getter
    //        set { name = value; } //Setter
    //    }
    //}

    //프로퍼티 자동구현

    //class Person
    //{
    //    private int count = 100;

    //    public string Name { get; set; } //자동 구현 프로퍼티

    //    public int Count
    //    {
    //        get { return count; } // 읽기만 가능
    //    }

    //    public float Balance { get; private set; } //외부 변경불가

    //    public void AddBal()
    //    {
    //        Balance += 100;
    //    }
    //}

    //마린클래스 
    //프로퍼티이용해서 이름과 미네랄을 만드시오, 이름 마린 미네랄50

    class Marin
    {

        public string name { get; set; }
        public int mineral { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {

            //C#에서 get/set 방식의 함수와 프로퍼티 비교 
            //C#에서 객체의 값을 읽고(get), 설정(set)하는 
            //방식으로 함수(get/set)또는
            //**프로퍼티(Property)**를 사용할 수 있습니다
            //Person P = new Person();

            //P.SetName("홍길동");

            //Console.WriteLine("이름 : " + P.GetName());

            //P.Name = "홍길동";
            //P.AddBal();
            //Console.WriteLine("이름 : " +P.Name+" Count : " +P.Count+ " Balance : " + P.Balance);

            Marin marin = new Marin();
            marin.name = "Marin";
            marin.mineral = 50;

            Console.WriteLine("이름 : " + marin.name + " Mineral : " + marin.mineral);

        }
    }
}
