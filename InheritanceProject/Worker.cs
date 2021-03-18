using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Worker: Human
    {
        public Worker(int height, int weight, string name)
            : base(height, weight, name)
        {

        }
    }
}
