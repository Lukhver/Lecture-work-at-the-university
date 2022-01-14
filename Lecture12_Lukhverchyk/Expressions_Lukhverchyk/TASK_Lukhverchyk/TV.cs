using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_Lukhverchyk
{
    class TV
    {
        private bool status;
        private bool mode;
        private int channel;
        private int volume;

        public TV()
        {
            status = false;
            mode = false;
            channel = 1;
            volume = 10;
        }

        public void menu()
        {
            if (mode == false)
            {
                Console.Clear();
                Console.WriteLine("1. Увiмкнути/вимкнути");
                Console.WriteLine("2. Режим налаштування/режим перегляду");
                Console.WriteLine("3. Наступний канал");
                Console.WriteLine("4. Попереднiй канал");
                Console.WriteLine("5. Задати номер каналу (з клавiатури)");
                Console.WriteLine("6. Збiльшити звук");
                Console.WriteLine("7. Зменшити звук");
                Console.WriteLine("9. Iнформацiя про поточнi налаштування");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("1. Увiмкнути/вимкнути");
                Console.WriteLine("2. Режим налаштування/режим перегляду");
                Console.WriteLine("8. Вимкнути звук");
            }
        }

        public void start() //передбачити можливість зміни статусу (вкл/вимк)
        {
            if (status)
            {
                status = false;
            }
            else
            {
                status = true;
            }
        }

        public void setting() //зміни режиму (перегляд/налаштування)
        {
            if (status)
            {
                if (mode)
                {
                    mode = false; //Перегляд
                }
                else
                {
                    mode = true;  //Налаштування
                }
            }
        }

        public void next_channel() //перемикання каналів (наступний канал)
        {
            if (status)
            {
                if (channel <= 99 && channel >= 1)
                {
                    channel++;
                }
                else
                {
                    return;
                }
            }
        }

        public void past_channel() //перемикання каналів (попередній канал)
        {
            if (status)
            {
                if (channel <= 99 && channel >= 1)
                {
                    channel--;
                }
                else
                {
                    return;
                }
            }
        }

        public void change_channel(int x) //перемикання каналів (перехід до каналу за номером)
        {

            if (status)
            {
                if (channel <= 99 && channel >= 1)
                {
                    channel = x;
                }
                else
                {
                    return;
                }
            }
        }

        public void up_volume() //зміни рівня звуку(голосніше)
        {
            if (status)
            {
                if (volume <= 99 && volume >= 0)
                {
                    volume++;
                }
                else
                {
                    return;
                }
            }
        }

        public void down_volume() //зміни рівня звуку(тихіше)
        {
            if (status)
            {
                if (volume <= 99 && volume >= 1)
                {
                    volume--;
                }
                else
                {
                    return;
                }
            }
        }

        public void off_volume() //можливість відключення звуку
        {
            if (status)
            {
                if (mode)
                {
                    if (volume <= 99 && volume >= 1)
                    {
                        volume = 0;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        public void show() //Передбачити метод виведення інформації про поточний стан і налаштування телевізора.
        {
            if (status)
            {
                Console.WriteLine("Телевiзор увiмкнений!");
                Console.WriteLine("Канал: №" + channel);
                if (volume == 0)
                {
                    Console.WriteLine("Увiмкнений режим вiдключеного звуку!");
                }
                else
                {
                    Console.WriteLine("Гучнiсть:" + volume);
                }
            }
            else
            {
                Console.WriteLine("Телевiзор вимкнений!");
            }
        }

    }
}
