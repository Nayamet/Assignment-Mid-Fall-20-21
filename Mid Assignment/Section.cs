using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Section
    {
        public string SectionName { get; set; }
        public Faculty teacher;
        public Course course;

        public Section()
        {
            Console.WriteLine("Empty Section Constructor.");
        }
        public Section(string sectionName,Faculty teacher,Course course            )
        {
            SectionName = sectionName;
            this.teacher = teacher;
            this.course = course;
        }
    }
}
