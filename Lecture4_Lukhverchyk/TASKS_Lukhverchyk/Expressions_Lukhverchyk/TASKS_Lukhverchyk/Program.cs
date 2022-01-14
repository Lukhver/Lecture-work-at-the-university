using System;

namespace TASKS_Lukhverchyk
{
    class Program
    {
        private static void Config()
        {
            Console.Title = "Expressions_Lukhverchyk";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }


        static bool ThisNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {   
                bool res = Char.IsNumber(str, i);
                if (!res)
                {return false;}
            }
            return true;
        }



        static void WhatTheCard(string cart_number)
        {
            char[] charArr = cart_number.ToCharArray();
            int[] aint = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));


            if (aint[0] == 4)
            {Console.WriteLine("\nТип Вашої карти: Visa");}
            if (aint[0] == 5 && (aint[1] == 1 || aint[1] == 2 || aint[1] == 3 || aint[1] == 4 || aint[1] == 5))
            {Console.WriteLine("\nТип Вашої карти: MasterCard");}
            if (aint[0] == 3 && (aint[1] == 4 || aint[1] == 7))
            {Console.WriteLine("\nТип Вашої карти: Аmerican Express");}
        }



        static bool Luna(string str)
        {
            char[] charArr = str.ToCharArray();
            int[] aint1 = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));
            int j = aint1.Length - 1;
            int Notm = 0;
            int Yesm = 0;



            for (int i = aint1.Length - 1; i >= 0; i--)
            {
                if (i != aint1.Length - 1 && i != j)
                {
                    if (aint1[i] * 2 > 9)
                    {Yesm += (aint1[i] * 2) % 10 + 1;}
                    else
                    {Yesm += aint1[i] * 2;}
                }
                else
                {
                    Notm += aint1[i];
                    j -= 2;
                }
            }



            bool res = (Notm + Yesm) % 10 == 0;
            return res;
        }



        static void Main(string[] args)
            {
                Config();
                Console.Write("Введiть будь-ласка, Ваш номер карти, для перевiрки на валiдацiю:\n\n");
                string cart_number = Console.ReadLine();
                bool is_number = ThisNumber(cart_number);
                bool status_len = false;

                if (cart_number.Length == 13 || cart_number.Length == 15 || cart_number.Length == 16)
                {status_len = true;}
                bool resaulLuna = Luna(cart_number);

                if (resaulLuna == true)
                {
                    WhatTheCard(cart_number);
                }
                
                if (resaulLuna == false)
                {
                    Console.WriteLine("\nТакої карти не iснує: INVALID");
                }
            Console.ReadKey();
            }
        }
    }