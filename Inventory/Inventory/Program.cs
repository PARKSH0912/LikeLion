using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {

        //최대 아이템 개수 (배열크기)
        const int MAX_ITEMS = 10;

        //아이템 배열 ( 이름저장 ) 
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemCounts = new int[MAX_ITEMS];
        
        //아이템 추가함수
        static void AddItems(String name ,int count)
        {
            for (int i=0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)
                {
                    itemCounts[i] += count;
                    return;
                }
            }
            for(int i =0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i] == null)
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }

        //아이템 제거 함수 
        static void RemoveItem(string name , int count)
        {
            for(int i=0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i] == name) // 이름하고 같은지
                {
                    if (itemCounts[i] >= count)//개수가 충분하면 차감
                    {
                        itemCounts[i] -= count;
                        if (itemCounts[i] == 0) //개수가 0이면 삭제
                        {
                            itemNames[i] = null;
                        }
                        return;
                    }

                }else
                {
                    Console.WriteLine("아이템 개수가 부족합니다");
                }
            }
            Console.WriteLine("아이템을 찾을수없습니다!");
        }

        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for(int i=0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i]!= null)
                {
                    Console.WriteLine($"{itemNames[i]}(x{itemCounts[i]})");
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어있습니다");
            }
        }

        static void Main(string[] args)
        {
            AddItems("포션", 5);
            AddItems("칼", 1);
            AddItems("포션", 3); //포션 개수 추가
            ShowInventory();


            //아이템사용
            Console.WriteLine("포션 2개사용");
            RemoveItem("포션", 2);
            ShowInventory();


            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem("방패", 1);
            ShowInventory();

            //테스트 : 모든 포션 제거
            Console.WriteLine("포션6개사용(초과 사용테스트 ");
            RemoveItem("포션", 7);
            ShowInventory();

        }
    }
}
