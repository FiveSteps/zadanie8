using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            studentlib.Student s = new studentlib.Student();

            s.AddStudent("1567", "Верховенский Петр Степанович", "11.08.2001", "ISIP");
            s.AddStudent("1668", "Салтыков Дмитрий Александрович", "23.11.2003", "ASAP");
            s.AddStudent("2208", "Лермонтов Алексей Геннадьевич", "07.02.1999", "ACAB");

            s.ShowInitials("2208");
            s.YoungerOlder("a");
            s.Search("Лермонтов");
        }
    }
}
