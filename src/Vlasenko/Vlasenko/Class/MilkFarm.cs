using System;
using System.Collections.Generic;
using System.Text;


namespace Vlasenko
{
    class MilkFarm
    {
        public List<Cheese> Cheeses { get; set; } = new List<Cheese>();
        int nextId = 0;

        public void AddCheese(int listSize)
        {
            for (int i = 0; i < listSize; i++)
            {
                int id = nextId++;
                string marka, proizvoditel;
                int procentZhirnosti = 0;
                bool flag = true;
                Console.Clear();

                Console.WriteLine($"ID {i + 1} для сыра: {id}");

                while (flag)
                {
                    Console.WriteLine($"Введите название марки сыра{i + 1}");
                    marka = Console.ReadLine().Trim();
                    if (marka.Length > 2)
                    {
                        Console.WriteLine("Данные успешно добавлены!");
                        continue;
                    }

                    Console.WriteLine("Неккоректный ввод!");

                    Console.WriteLine($"Введите название производителя {i + 1}");
                    proizvoditel = Console.ReadLine().Trim();
                    if (proizvoditel.Length > 5)
                    {
                        Console.WriteLine("Данные успешно добавлены!");
                        continue;
                    }
                    Console.WriteLine("Неккоректный ввод!");

                    Console.WriteLine($"Введите срок годности сыра{i + 1}");
                    procentZhirnosti = Convert.ToInt32(Console.ReadLine());
                    if (procentZhirnosti > 0 || procentZhirnosti <= 20)
                    {
                        Console.WriteLine("Данные успешно добавлены!");
                        continue;
                    }
                    Console.WriteLine("Неккоректный ввод!");

                    Cheese cheese = new Cheese()
                    {
                        Id = id,
                        Marka = marka,
                        Proizvoditel = proizvoditel,
                        ProcentZhirnosti = procentZhirnosti
                    };

                    Cheeses.Add(cheese);

                    Console.WriteLine("Все данные успешно добавлены!");
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        //public void SortCheese()
        //{
        //    Console.WriteLine("Выберите тип сортировки");
        //    Console.WriteLine("Сортировка выполнена!");
        //    Console.WriteLine("");
        //    Console.ReadKey();
        //    Console.Clear();

        //}

        public void WriteCheese()
        {
            Console.WriteLine("Введите путь и имя файла, куда вы хотите сохранить данные!");
            string fileCheese = Console.ReadLine().Trim();
            Console.ReadLine();
            try
            {

                using (WriteCheese file = new WriteCheese())
                {
                    {
                        foreach()
                        {
                            Console.WriteLine($"{cheese.marka},{cheese.proizvoditel}, {cheese.procentZhirnosti}");
                        }
                    }

                }
            }
            catch (Exception e)
            {

            }

            Console.WriteLine("Файл успешно сохрнен");
            Console.WriteLine("При сохранении файла произошла ошибка");

        }
    }
}


