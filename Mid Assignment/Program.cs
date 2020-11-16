using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("CSE");

            Faculty f1 = new Faculty("Nayamet Ullah","F101");
            Faculty f2 = new Faculty("Rakib Musabbir", "F201");

            Course c1 = new Course("OOP2", "1111", 5);
            Course c2 = new Course("OOP1", "2222", 5);
            Course c3 = new Course("C++", "3333", 6);

            Section s1 = new Section("A", f1, c1);
            Section s2 = new Section("A", f1, c2);
            Section s3 = new Section("B", f2, c1);
            Section s4 = new Section("B", f2, c2);
            Section s5 = new Section("A", f2, c3);
            Section s6 = new Section("B", f2, c3);

            d1.AddCourse(c1, c2, c3);

            c1.AddSection(s1, s3);
            c2.AddSection(s2, s4);
            c3.AddSection(s5);

            c1.ShowInfo();
            Console.WriteLine();
            c2.ShowInfo();
            Console.WriteLine();
            c3.ShowInfo();

            f1.AddFacultySection(s1);
            f1.AddFacultySection(s2);
            f2.AddFacultySection(s3);
            f2.AddFacultySection(s4);
            f2.AddFacultySection(s5);
            f2.AddFacultySection(s6);

            Console.WriteLine();
            f1.FacultyInfo();
            Console.WriteLine();
            f2.FacultyInfo();


        }
    }
}
