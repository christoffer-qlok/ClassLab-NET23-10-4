using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab
{
    internal class SchoolClass
    {
        public int NumberOfStudents;
        public string Name;

        public double AttendingPercentage(int studendsAttending)
        {
            return (double)studendsAttending / NumberOfStudents * 100;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} has {NumberOfStudents} students");
        }

        public void PrintInfo(int studentsAttending)
        {
            Console.WriteLine($"{Name} has {NumberOfStudents} students with {AttendingPercentage(studentsAttending):0.##}% of them in school");
        }
    }
}
