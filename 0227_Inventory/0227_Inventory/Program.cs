using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inventory
{
    class Program
    {
        static string[] ItemNames = new string[max];
        static int[] ItemCount = new int[max];

        const int max = 10;

        struct Inventory
        {

            public void AddItems(string name, int count)
            {
                for (int i = 0; i < max; i++)
                {
                    if (ItemNames[i] == name)
                    {
                        ItemCount[i] += count;
                        return;
                    }
                }
                for (int i = 0; i < max; i++)
                {
                    if (ItemNames[i] == null)
                    {
                        ItemNames[i] = name;
                        ItemCount[i] = count;
                        return;
                    }
                }
            }
            public void RemoveItem(string name, int count)
            {
                for (int i = 0; i < max; i++)
                {
                    if (ItemNames[i] == name) // 이름하고 같은지
                    {
                        if (ItemCount[i] >= count)//개수가 충분하면 차감
                        {
                            ItemCount[i] -= count;
                            if (ItemCount[i] == 0) //개수가 0이면 삭제
                            {
                                ItemNames[i] = null;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("아이템 개수가 부족합니다");
                        }
                    }
                }
                Console.WriteLine("아이템을 찾을수없습니다!");
            }

            public void ShowInventory()
            {
                Console.WriteLine("현재 인벤토리 : ");
                bool isEmpty = true;

                for (int i = 0; i < max; i++)
                {
                    if (ItemNames[i] != null)
                    {
                        Console.WriteLine($"{ItemNames[i]}(x{ItemCount[i]})");
                        isEmpty = false;
                    }
                }
                if (isEmpty)
                {
                    Console.WriteLine("인벤토리가 비어있습니다");
                }

            }
        }

        static void Main(string[] args)
        {
            Inventory inv = new Inventory();

            inv.AddItems("포션", 5);
            inv.AddItems("칼", 1);
            inv.AddItems("포션", 3); //포션 개수 추가
            inv.ShowInventory();


            //아이템사용
            Console.WriteLine("포션 2개사용");
            inv.RemoveItem("포션", 2);
            inv.ShowInventory();


            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            inv.RemoveItem("방패", 1);
            inv.ShowInventory();

            //테스트 : 모든 포션 제거
            Console.WriteLine("포션6개사용(초과 사용테스트 ");
            inv.RemoveItem("포션", 7);
            inv.ShowInventory();

        }
    }
}