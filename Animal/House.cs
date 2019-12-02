using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class House
    {

        List<Animal> animalList = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            animalList.Add(animal);
        }

        public void Print()
        {
            Console.WriteLine("Följande djur finns i huset: ");

            foreach (Animal animal in animalList)
            {
                animal.Print();
            }
        }
    }
}
