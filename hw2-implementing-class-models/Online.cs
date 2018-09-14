using System;

namespace Homework
{
    public class Online : Section
    {

        public Online(Semester semester, Course course, Faculty teacher, string number, int cap)
            : base(semester, course, teacher, number, cap)
        {
        }

        public override string ToString()
            => $"{_course.Number} section {Number} ({_course.Title}) is being taught by {_faculty.GetName()} in {_semester.Name}";
    }
}