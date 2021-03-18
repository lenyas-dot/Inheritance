using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Student: Human
    {
        public string Specialty;
        public Student(int height, int weight, string name, string specialty)
            :base(height, weight, name)
        {
            Specialty = specialty;
        }
    }
}
