using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TASKS_Lukhverchyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Config();
            checking();
            Console.ReadKey();
        }
        static void checking()
        {
            string condition = @"(^\+380\d{2}-\d{3}-\d{2}-\d{2})"; 
            //string condition = @"(^\+380[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2})"; //Ще один варіант регулярного виразу для виконання цього завдання

            while (true)
            {
                Console.WriteLine("Введiть будь ласка Ваш номер телефону по наступнiй схемi (+380ХХ-ХХХ-ХХ-ХХ):");

                // Console.Write("+380");

                string phone = Console.ReadLine();

                if (Regex.IsMatch(phone, condition, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Номер пiдтверджено!");
                    break;
                }
                else
                { Console.WriteLine("Некоректний номер!"); }
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