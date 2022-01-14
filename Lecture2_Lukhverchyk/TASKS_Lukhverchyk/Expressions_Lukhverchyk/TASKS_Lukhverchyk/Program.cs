using System;

namespace TASKS_Lukhverchyk
{
    class Program
    {
        static void piramida2()
        {

            Console.WriteLine("Впишiть Height вiд 1 до 8:");

            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i > a;)
            {
                Console.WriteLine("Height введено не коректно, введiть iншу велечину вiд 1-8: ");
                a = int.Parse(Console.ReadLine());

                for (int b = 8; b < a;)
                {
                    Console.WriteLine("Height введено не коректно, введiть iншу велечину вiд 1-8: ");
                    a = int.Parse(Console.ReadLine());
                }
            }

            for (int b = 8; b < a;)
            {

                Console.WriteLine("Height введено не коректно, введiть iншу велечину вiд 1-8: ");
                a = int.Parse(Console.ReadLine());

                for (int i = 1; i > a;)
                {
                    Console.WriteLine("Height введено не коректно, введiть iншу велечину вiд 1-8: ");
                    a = int.Parse(Console.ReadLine());

                }
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine("#  #");
                    break;
                case 2:
                    Console.WriteLine(" #  # \n##  ##");
                    break;
                case 3:
                    Console.WriteLine("  #  #  \n ##  ## \n###  ###");
                    break;
                case 4:
                    Console.WriteLine("   #  #   \n  ##  ##  \n ###  ### \n####  ####");
                    break;
                case 5:
                    Console.WriteLine("    #  #    \n   ##  ##   \n  ###  ###  \n ####  #### \n#####  #####");
                    break;
                case 6:
                    Console.WriteLine("     #  #     \n    ##  ##    \n   ###  ###   \n  ####  ####  \n #####  ##### \n######  ######");
                    break;
                case 7:
                    Console.WriteLine("      #  #      \n     ##  ##     \n    ###  ###    \n   ####  ####   \n  #####  #####  \n ######  ######\n#######  #######");
                    break;
                case 8:
                    Console.WriteLine("       #  #       \n      ##  ##      \n     ###  ###     \n    ####  ####    \n   #####  #####   \n  ######  ######  \n #######  ####### \n########  ########");
                    break;
                default:
                    break;
            }

        }

        static void minipiramida()
        {
            int caunt1;
            do
            {
                Console.WriteLine("Впишiть Height вiд 1 до 8:");
                bool resault1 = int.TryParse(Console.ReadLine(), out caunt1);

                if (resault1 && (caunt1 > 0 && caunt1 <= 8))
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Height: " + caunt1);

            int stage1 = caunt1 - 1;

            for (int i = 0; i < caunt1; i++)
            {
                for (int j = 0; j < caunt1; j++)
                {
                    if (j < stage1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
                stage1 = stage1 - 1;
            }
        }

        static void piramidailla()
        {

            int caunt;
            do
            {
                Console.WriteLine("Впишiть Height вiд 1 до 8:");
                bool resault = int.TryParse(Console.ReadLine(), out caunt);

                if (resault && (caunt > 0 && caunt <= 8))
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Height: " + caunt);

            int stage = caunt - 1;

            for (int i = 0; i < caunt; i++)
            {
                for (int j = 0; j < caunt; j++)
                {
                    if (j < stage)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.Write("  ");
                for (int j = 0; j < caunt - stage; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
                stage = stage - 1;
            }
        }

        static void kasa()
        {
            int coin25 = 0, coin10 = 0, coin5 = 0, coin1 = 0;
            Console.WriteLine("Введiть решту: ");
            double cash = double.Parse(Console.ReadLine());
            while (cash >= 0.25)
            {
                cash = cash - 0.25;
                coin25++;
            }
            while (cash >= 0.1)
            {
                cash = cash - 0.1;
                coin10++;
            }
            while (cash >= 0.05)
            {
                cash = cash - 0.05;
                coin5++;
            }
            while (cash > 0)
            {
                cash = cash - 0.01;
                coin1++;
            }
            int coin = coin25 + coin10 + coin5 + coin1;
            Console.WriteLine("Загальна кiлькiсть монет - " + coin);
            Console.WriteLine("номiнал 25 - " + coin25 + " шт");
            Console.WriteLine("номiнал 10 - " + coin10 + " шт");
            Console.WriteLine("номiнал 5 - " + coin5 + " шт");
            Console.WriteLine("номiнал 1 - " + coin1 + " шт");
        }

        static void chose()
        {
            Console.WriteLine("Доступнi завдання для виконання:\n1.Пiрамiда\n2.Мiнi пiрамiда\n3.Каса\n\n");
            int task;

            do
            {
                Console.WriteLine("Вас цiкавить завдання пiд номером: ");
                bool resault1 = int.TryParse(Console.ReadLine(), out task);

                if (resault1 && (task > 0 && task <= 3))
                {
                    break;
                }
            } while (true);
            if (task == 1)
            {
                Console.WriteLine("Привiт, тобi потрiбно обрати спосiб вирiшення завдання з пiрамiдкою. \nЄ два варiанти розв'язку:\n\n1)Спосiб, який використовує за основу, оператор вибору - switch\n2)Спосiб, в якому iдея алгоритма була запозичена, у одногрупника Iллi.(Дуже крутий алгоритм)\n\nТвiй варiант:");
                int variant = int.Parse(Console.ReadLine());

                switch (variant)
                {
                    case 1:
                        piramida2();
                        break;
                    case 2:
                        piramidailla();
                        break;
                    default:
                        Console.WriteLine("Такий собi вибiр, як визначишся, приходь!");
                        break;
                }
            }
            else
                if (task == 2)
            {
                minipiramida();
            }
            else
                if (task == 3)
            {
                kasa();
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Expressions_Lukhverchyk";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            chose();
            Console.WriteLine("\nДякую за користування!");
            Console.ReadKey();
        }
    }
}