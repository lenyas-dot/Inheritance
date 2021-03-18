using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Human
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; private set; }

        public Human(int height, int weight, string name)
        {
            Height = height;
            Weight = weight; //можно без конструктора для роста и веса, так как прописаны автоматические свойства для этих полей
            Name = name;
        }
        public void Say()
        {
            Console.WriteLine($"Привет, я {Name}!");

        }

    }
}
