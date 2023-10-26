using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public Teacher(string name, string className, string section)
        {
            Name = name;
            Class = className;
            Section = section;
        }
    }
}
