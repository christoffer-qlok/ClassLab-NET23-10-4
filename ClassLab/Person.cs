using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab
{
    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string SSN { get; set; }

        public string Hobby { get; set; }

        public bool IsRetired
        {
            get
            {
                return Age >= 65;
            }
        }

        public static Person Oldest(Person person1, Person person2)
        {
            if (person1.Age > person2.Age)
            {
                return person1;
            } else
            {
                return person2;
            }
        }
    }
}
