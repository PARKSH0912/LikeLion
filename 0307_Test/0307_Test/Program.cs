using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0307_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();
            Fight fight = new Fight();


            Console.WriteLine("test");

            while (true)
            {
                Console.Clear();
                player.Job_Select();


                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1. 하수");
                    Console.WriteLine("2. 중수");
                    Console.WriteLine("3. 고수");

                    int iInput = int.Parse(Console.ReadLine());


                }


            }

        }
    }
}
