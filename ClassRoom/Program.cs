using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom Class = new ClassRoom("3Q", new List<Student>(), new DateTime(2019, 08, 26));
            Class.ClassList.Add(new Student("Pedro Rainho", 12, 7));
            Class.ClassList.Add(new Student("Natalie Christiansen", 10, 16));

            foreach (var x in Class.ClassList)
            {
                Console.WriteLine($"Name: {x.Name} \n Birth Date: {x.Birthday} Month: {x.BirthMonth}\n\n");
            }

            Console.ReadKey();
        }
    }
}
