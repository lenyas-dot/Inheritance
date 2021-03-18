using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Human human1 = new Human(170, 60, "Leonid");
            Human human2 = new Human(175, 65, "Artem");
            Human human3 = new Human(165, 75, "Alexey");

            Student student = new Student(165, 70, "Mihail", "IT");

            student.Say();
            sayHello(student);
            student.Height += 2;
            student.Weight -= 2;

            Miner miner = new Miner(165, 62, "Nikita");
            sayHello(miner);
            
            
            
            Console.ReadKey();
        }

        static void sayHello(Human human)
        {
            Console.WriteLine($"Hello World! I am {human.Name}");
        }
    }
}
