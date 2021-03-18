using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Miner: Worker
    {
        
        
        public Miner(int height, int weight, string name)
            :base(height, weight, name)
        {


        }
    }
}
