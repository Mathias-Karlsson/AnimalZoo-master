using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal[] allAnimals;
            int i;

            allAnimals = new Animal[3];

            Animal kurre = new Cat("Kurre");
            Animal vilma = new Dog("Vilma");
            Animal bamse = new Cat("Bamse");

            kurre.setAge(6);
            vilma.setAge(3);
            bamse.setAge(5);


            allAnimals[0] = kurre;
            allAnimals[1] = vilma;
            allAnimals[2] = bamse;

            Toy ball = new Toy ("Boll");
            Toy shoe = new Toy ("Tuggsko");
            Toy mouse = new Toy ("Plastmus");

            House house = new House();

            house.AddAnimal(kurre);
            house.AddAnimal(vilma);
            house.AddAnimal(bamse);

            kurre.SetFriend(vilma);
            vilma.SetFriend(bamse);
            bamse.SetFriend(kurre);

            house.Print();

            Console.WriteLine("Current year: " + Animal.currentYear);
            i = 0;
            while (i < allAnimals.Length)
            {
                // will this work?  should it?
                Console.WriteLine("Nu kommer " + allAnimals[i].name);

                allAnimals[i].IntroduceYourself();
                i = i + 1;
            }
            Console.ReadKey();
        }
    }
}
