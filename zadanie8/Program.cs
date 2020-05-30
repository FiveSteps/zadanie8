using System;
using System.Collections.Generic;
using studentlib;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            int g = 0;

            while (g != 6)
            {
                Console.WriteLine("Введите цифру: \n" +
                    "1-Показать Информацию о студентах\n" +
                    "2-Добавить студента\n" +
                    "3-Удалить студента\n" +
                    "4-Изменить студента\n" +
                    "5-Поиск студентов\n" +
                    "6-Выход\n");

                int s = Convert.ToInt32(Console.ReadLine());
                g = s;

                switch (s)
                {
                    case 1:
                        Console.WriteLine("Теперь выберите один из пунктов: \n" +
                            "1-Вся информация о студентах\n" +
                            "2-Список студентов с инициалами\n" +
                            "3-Список студентов старше 18\n" +
                            "4-Список студентов младше 18\n");

                        int k = Convert.ToInt32(Console.ReadLine());
                        if (k == 1)
                        {
                            Console.Write("Введите id студента: ");
                            string enterId1 = Console.ReadLine();

                            st.ShowStudentById(enterId1);
                        }
                        else if (k == 2)
                        {
                            Console.Write("Введите id студента: ");
                            string enterId2 = Console.ReadLine();

                            st.ShowInitials(enterId2);
                        }
                        else if (k == 3) st.YoungerOlder("a");
                        else if (k == 4) st.YoungerOlder("s");
                        break;
                    case 2:
                        Console.WriteLine("Последовательно введите данные студента для добавления \n");
                        Console.Write("id: ");
                        string enterId = Console.ReadLine();
                        Console.Write("ФИО(через пробел): ");
                        string enterFio = Console.ReadLine();
                        Console.Write("Дату рождения: ");
                        string enterBirthday = Console.ReadLine();
                        Console.Write("Группу: ");
                        string enterGroup = Console.ReadLine();

                        st.AddStudent(enterId, enterFio, enterBirthday, enterGroup);
                        break;
                    case 3:
                        Console.Write("Введите id студента, которого хотите удалить из базы данных: ");
                        string enterId3 = Console.ReadLine();

                        st.DelStudent(enterId3);
                        break;
                    case 4:
                        Console.WriteLine("Последовательно введите данные студента для изменения \n");
                        Console.Write("id: ");
                        string enterId4 = Console.ReadLine();
                        Console.Write("ФИО(через пробел): ");
                        string enterFio4 = Console.ReadLine();
                        Console.Write("Дату рождения: ");
                        string enterBirthday4 = Console.ReadLine();
                        Console.Write("Группу: ");
                        string enterGroup4 = Console.ReadLine();

                        st.ChangeStudent(enterId4, enterFio4, enterBirthday4, enterGroup4);
                        break;
                    case 5:
                        Console.Write("Введите фамилию студента: ");
                        string enterSurname = Console.ReadLine();

                        st.Search(enterSurname);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
