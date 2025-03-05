using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study26
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = { "Charlie", "Alice", "Bob" };

            //var sortedNames = names.OrderBy(n => n);

            //foreach (var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var firstName = names.First(n => n.StartsWith("A"));
            //Console.WriteLine($"First name Starting wiht A:{firstName}");



            ////메서드 구문 , 쿼리구문
            //int[] nums = { 5, 3, 8, 1 };

            ////메서드 구문
            //var sortedMeshod = nums.OrderBy(n => n);
            //var sortedQuery = from n in nums orderby n select n;

            //Console.WriteLine("Meshod syntax:");
            //foreach(var n in sortedMeshod)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("sortedQuery:");
            //foreach (var n in sortedQuery)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] words = { "apple", "banana", "Cherry" };

            ////Select()로 길이 추출
            //var lengths = words.Select(w => w.Length);

            //foreach (var length in lengths)
            //{
            //    Console.WriteLine(length);
            //}

            ////select 개념
            ////linq 쿼리 연산자 중 하나
            ////각 요소를 변환하여 새로운 컬렉션을 생성

            //var upperWords = words.Select(w => w.ToUpper());

            //foreach(var word in upperWords)
            //{
            //    Console.WriteLine(word);
            //}

            //sum 알고리즘
            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //foreach (var d in data)
            //    sum += d;
            //Console.WriteLine($"Sum : {sum}");


            ////count 
            //int[] data = { 1, 2, 3, 4, 5 };
            //int count = data.Length; //개수
            //Console.WriteLine($"Count : {count}");

            //float[] data = { 80, 76, 65 };
            //double avg = data.Average();
            //Console.WriteLine($"Average: {avg:F2}");

            //int[] data = { 1, 2, 3, 4, 5 };

            //int max = data.Max();
            //Console.WriteLine(max);

            //int min = data.Min();

            //Console.WriteLine($"Min : {min}");


            //int[] data = { 10, 12, 20, 25, 30 };
            //int target = 22;
            //int nearest = data[0];

            //foreach(var d in data)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target))
            //        nearest = d;
            //}

            //Console.WriteLine($"Nearest tp {target}: {nearest}");


            //순위ㅏ 구하기 Rank알고리즘
            //각 요소가 몇 번째로 큰 지 순위를 매기는 예제

            //int[] scores = { 90, 70, 50, 70, 60 };
            //for(int i=0; i<scores.Length; i++)
            //{
            //    int rank = 1;
            //    for (int j=0; j<scores.Length; j++)
            //    {
            //        if (scores[j] > scores[i])
            //        {
            //            rank++;
            //        }
            //    }
            //    Console.WriteLine($"scores : {scores[i]}, Rank{rank}");
            //}

            //int[] data = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);

            //foreach(var d in data){
            //    Console.WriteLine(d);
            //}

            //특정값 검색

            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;

            //for (int i =0; i<data.Length; i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not Found");


            //그룹화 하기 : GROUP 알고리즘
            //데이터를 특정 기준으로 그룹화하기

            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            var groups = fruits.GroupBy(f => f[0]);

            foreach(var group in groups)
            {
                Console.WriteLine($"key {group.Key}");

                foreach(var item in group)
                {
                    Console.WriteLine($"{item}");
                }
            }


        }
    }
}
