using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Faculty
    {
        public string FacultyName
        { get; set; }
        public string FacultyId { get; set; }
        public int WeeklyWorkingLoad { get; set; }
        public Section[] facultySection;
        public int FacultyTotalSection { get; set; }
        public Faculty()
        {
            Console.WriteLine("Empty Faculty Constructor.");
            facultySection = new Section[10];
        }
        public Faculty(string facultyName,string facultyId)
        {
            FacultyName = facultyName;
            FacultyId = facultyId;
            WeeklyWorkingLoad = 0;
            FacultyTotalSection = 0;
            facultySection = new Section[10];
        }
        public void AddFacultySection(Section section)
        {
            int temp = WeeklyWorkingLoad + section.course.TeachingHour;
            if (temp <= 21)
            {
                facultySection[FacultyTotalSection++] = section;
                WeeklyWorkingLoad += section.course.TeachingHour;
            }
            else
                Console.WriteLine("We can't assign {0} for any section in this course.\nBecause his weekly load hour cross the maximum limit 21.",section.teacher.FacultyName);
        }
        public void FacultyInfo()
        {
            Console.WriteLine("Faculty Name :" + FacultyName);
            Console.WriteLine("Faculty ID :" + FacultyId);
            Console.WriteLine("Weekly Working Load :" + WeeklyWorkingLoad+"Hour");
            Console.WriteLine("Sections are : ");
            for(int i=0;i<FacultyTotalSection;i++)
            {
                Console.WriteLine("Course Name: {0}\nSection Name : {1}",facultySection[i].course.CourseName,facultySection[i].SectionName );
            }
        }
    }
}
