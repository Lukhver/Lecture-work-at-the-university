using System;

namespace TASK_Lukhverchyk
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            int k = 1;
            while (k != 0)
            {
                tv.menu();
                k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                {
                    tv.start();
                }
                else if (k == 2)
                {
                    tv.setting();
                }
                else if (k == 3)
                {
                    tv.next_channel();
                }
                else if (k == 4)
                {
                    tv.past_channel();
                }
                else if (k == 5)
                {
                    tv.change_channel(Convert.ToInt32(Console.ReadLine())); 
                }
                else if (k == 6)
                {
                    tv.up_volume();
                }
                else if (k == 7)
                {
                    tv.down_volume();
                }
                else if (k == 8)
                {
                    tv.off_volume();
                }

                else if (k == 9)
                {
                    Console.Clear();
                    tv.show();
                    Console.ReadLine();
                }
            }
            Console.Read();
        }

        }
    }
