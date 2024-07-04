using System;
using System.Collections.Generic;

namespace Vlasenko
{
    class Program
    {
        static void Main(string[] args)
        {
            int listSize;
            MilkFarm milkFarm = new MilkFarm();
            Console.WriteLine("Введите количество сыров, которо вы хотите добавить");
            bool flag = true;
            while (flag)
            {              
                if (!int.TryParse(Console.ReadLine(), out listSize) || listSize > 0)
                {

                    Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                   
                }
                flag = false;
            }

            milkFarm.AddCheese(listSize);

            milkFarm.WriteCheese();

        }
    }
}
