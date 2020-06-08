using System;
using static stlib;

namespace zadanie8
{
    class Program
    {
        public static void Menu()
        {
            Student lo = new Student();
            Console.WriteLine("Выберите действие:\n1 - Вывести информацию\n2 - Добавить студента\n3 - Удалить студента\n4 - Изменить студента\n5 - Поиск студентов\n6 - Выход");
            int kartoshka = Convert.ToInt32(Console.ReadLine());
            switch (kartoshka)
            {
                case 1:
                    Console.WriteLine("Выберите доп.действие\n1 - Вся информация о студентах\n2 - Список студентов с инициалами\n3 -Список студентов старше или младше 18");
                    int v1 = Convert.ToInt32(Console.ReadLine());
                    if (v1 == 1) lo.Info();
                    else if (v1 == 2) lo.InfFIO();

                    else if (v1 == 3) lo.Vvoz();
                    break;
                case 2:
                    lo.Dobavit();
                    break;
                case 3:
                    lo.Delete();
                    break;
                case 4:
                    lo.Izmenit();
                    break;
                case 5:
                    Console.WriteLine("Выберите доп.действие\n1 - Поиск по фамилии\n2 - Поиск по ID");
                    int v2 = Convert.ToInt32(Console.ReadLine());
                    if (v2 == 1) lo.poiskpoF();
                    if (v2 == 2) lo.infID();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            Menu();
        }
        static void Main(string[] args)
        {

            Menu();
        }
    }
}

