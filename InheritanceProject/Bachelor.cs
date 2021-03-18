using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Bachelor: Student
    {

        public Bachelor(int height, int weight, string name, string speciality)
            :base(height, weight, name, speciality)
        {

        }
    }
}
