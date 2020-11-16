using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Department
    {
        public string DepartmentName { get; set; }
        Course[] courses;
        public int TotalCourses { get; set; }
        public Department()
        {
            courses = new Course[100];
            Console.WriteLine("Empty Deparment Constructor.");
        }
        public Department(string departmentName)
        {
            courses = new Course[100];
            DepartmentName = departmentName;
            TotalCourses = 0;
        }
        public void AddCourse(params Course[] courses)
        {
            foreach(var course in courses)
            {
                if(TotalCourses<100)
                {
                    this.courses[TotalCourses++]= course;
                }
                
            }
        }


    }
}
