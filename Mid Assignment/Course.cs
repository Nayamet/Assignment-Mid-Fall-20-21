using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Course
    {
        Section[] sections;
        public int TotalSection { get; set; }
        public string CourseName { get; set; }
        public string CourseId { get; set; }
        public int TeachingHour { get; set; }

        public Course()
        {
            Console.WriteLine("Empty Course Constructor.");
            sections = new Section[25];
        }
        public Course(string courseName,string courseId,int teachingHour)
        {
            CourseName = courseName;
            CourseId = courseId;
            TeachingHour = teachingHour;
            sections = new Section[25];
            TotalSection = 0;
        }

        public void AddSection(params Section[] sections)
        {
            if (TotalSection < 25)
            {
                foreach (var section in sections)
                {
                    this.sections[TotalSection++] = section;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Course ID :" + CourseId);
            Console.WriteLine("Teaching hour : " + TeachingHour);
            Console.WriteLine("Total Section :" + TotalSection);
            for(int i=0;i<TotalSection;i++)
            {
                Console.WriteLine("Section Name : {0}\nFaculty Name :{1}", sections[i].SectionName, sections[i].teacher.FacultyName);
            }
        }


    }
}
