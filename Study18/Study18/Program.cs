using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study18
{

    struct Rectangle
    {
        public int Width;
        public int Height;


        public int GetArea() => Width * Height;
    }

    struct Point
    {
        public int x;
        public int y;
    }

    struct Grade
    {
        public string Name;
        public int Kor;
        public int Eng;
        public int Math;
    }




    class Program
    {
        struct Student
        {
            public string Name;  //학생 이름
            public int iKor;     //국어
            public int iEng;     //영어
            public int iMath;    //수학

            //학생 정보를 출력하는 함수
            public void Print()
            {
                Console.WriteLine($"{Name,-3} {iKor,5} {iEng,7}{iMath,8}");
            }
        }
        static void Main(string[] args)
        {
            ////var rect = new Rectangle { Width = 5, Height = 4 };
            //Rectangle rect;
            //rect.Width = 5;
            //rect.Height = 10;

            //Console.WriteLine($"Area:{rect.GetArea()}");


            Point[] points = new Point[2];
            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;


            //foreach(var point in points)
            //{
            //    Console.WriteLine($"Point :{point.x}.{point.y}");
            //}

            // 구조체를 이용해서
            // 학생 3명의 이름 성적을 받고 국어,영어,수학
            // 출력하시오
            // 이름 국어 영어 수학
            // 홍길동 100 80  70 
            // 홍길동 90  10  20 
            // 홍길동 20 55  70 


            //for (int i = 0; i < 3; i++)
            //{
            //    Grade[] grade = new Grade[3];
            //    Console.WriteLine("이름을 입력하세요");
            //    string name = Console.ReadLine();
            //    grade[i].Name = name;
            //    Console.WriteLine("국어 점수를 입력하세요");
            //    int kor = int.Parse(Console.ReadLine());
            //    grade[i].Kor = kor;
            //    Console.WriteLine("영어 점수를 입력하세요");
            //    int eng = int.Parse(Console.ReadLine());
            //    grade[i].Eng = eng;
            //    Console.WriteLine("수학 점수를 입력하세요");
            //    int math = int.Parse(Console.ReadLine());
            //    grade[i].Math = math;
            //    for(int j = 0; j)
            //    foreach (var Grade in grade)
            //    {
            //        Console.WriteLine($"이름 : {Grade.Name} 국어 : {Grade.Kor} 영어 : {Grade.Eng} 수학 : {Grade.Math}");
            //        Thread.Sleep(5000);
            //    }
            //}








            Student[] students = new Student[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("학생성적을 입력하세요.");
                Console.Write("학생이름 : ");
                students[i].Name = Console.ReadLine();
                Console.Write("국어 : ");
                students[i].iKor = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                students[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                students[i].iMath = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("이름    국어    영어    수학");

            foreach (Student std in students)
            {
                std.Print();
            }
        }
    }
}

