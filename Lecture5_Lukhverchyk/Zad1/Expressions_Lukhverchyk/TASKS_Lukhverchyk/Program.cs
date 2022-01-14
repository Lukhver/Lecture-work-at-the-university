using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS_Lukhverchyk
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Config();
            Console.WriteLine("Вхiднi данi (вводити через пробiл):");
            lalala();
            Console.ReadKey();
        }
        static void lalala()
        {

            string q = Console.ReadLine();
            string[] xyz = q.Split(' ');
            int x = Convert.ToInt32(xyz[0]);
            int y = Convert.ToInt32(xyz[1]);
            int z = Convert.ToInt32(xyz[2]);

            Console.Write("\nРезультат: Everybody sing a song:");
            if (y == 0 || x == 0) //відпавідає за те, щоб при нульовому значенні у або х не ставило пробіл
            {
                Console.Write("");
            }
            else
            {
                Console.Write(" ");
                for (int i = 0; i < y;)       //повторює приспів лалала у разів
                {
                    i++;
                    for (int a = 0; a < x;)     //повторює частинку ла х разів в одному слові
                    {
                        a++;
                        Console.Write("la");
                        if (x != a)               //розставляє між лалала "-", а після всіх лалала " "
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            if (x == a && y == i)   //допомагає визначити коли всі слова закінчилось, а коли ще ні
                            {
                                Console.Write("");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }

                    }
                }
            }
            if (z == 1)     //визначає кінцевий знак
            {
                Console.Write("!");
            }
            else
            {
                Console.Write(".");
            }
        }
        static void Config()
        {
            Console.Title = "Expressions_Lukhverchyk";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}