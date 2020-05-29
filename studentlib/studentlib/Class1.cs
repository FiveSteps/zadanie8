using System;
using System.Collections.Generic;

namespace studentlib
{
    public class Student
    {
        public string id;
        public string fio;
        public string group;
        public string birthDate;

        static List<Student> studentList = new List<Student>();

        public void AddStudent(string id, string fio, string birthDate, string group)
        {
            studentList.Add(new Student() { id = id, fio = fio, birthDate = birthDate, group = group });
        }


        public void DelStudent(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id) studentList.RemoveAt(i);
            }
        }

        public void ChangeStudent(string id, string fio, string birthDate, string group)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    studentList[i].fio = fio;
                    studentList[i].birthDate = birthDate;
                    studentList[i].group = group;
                }
            }

        }

        public void ShowStudentFio()
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + studentList[i].fio);
            }
            Console.WriteLine();
        }

        public void ShowStudentById(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                    Console.WriteLine(
                        studentList[i].id + " - "
                        + studentList[i].fio + " - "
                        + studentList[i].birthDate + " - "
                        + studentList[i].group
                    );
            }
            Console.WriteLine();
        }

        public void ShowStudentAge(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    string[] studentListSplit = studentList[i].birthDate.Split('.');
                    int ourYear = 2020;

                    if (int.TryParse(studentListSplit[2], out int res))
                    {
                        int takeAge = ourYear - res;
                        Console.Write("Возраст студента с id " + id + ": " + takeAge + " лет");
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public void ShowInitials(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    string[] studListSplit = studentList[i].fio.Split(' ');

                    Console.WriteLine(studListSplit[0] + " " + studListSplit[1][0] + "." + studListSplit[2][0] + ".");
                }
            }
            Console.WriteLine();
        }

        public void YoungerOlder(string parametr)
        {
            string[] studentListSplit;
            int ourYear;
            int takeAge;

            for (int i = 0; i < studentList.Count; i++)
            {
                studentListSplit = studentList[i].birthDate.Split('.');
                ourYear = 2020;


                if (int.TryParse(studentListSplit[2], out int res))
                {
                    takeAge = ourYear - res;

                    if (parametr == "s" && takeAge < 18) Console.WriteLine(studentList[i].fio + " возраст: " + takeAge);
                    if (parametr == "a" && takeAge > 18) Console.WriteLine(studentList[i].fio + " возраст: " + takeAge);
                }
            }
            Console.WriteLine();
        }

        public void Search(string surname)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                string[] surnameNew = studentList[i].fio.Split(' ');

                if (surnameNew[0] == surname)
                {
                    Console.WriteLine(
                       studentList[i].id + " - "
                       + studentList[i].fio + " - "
                       + studentList[i].birthDate + " - "
                       + studentList[i].group
                   );
                }
            }
            Console.WriteLine();
        }
    }
}


